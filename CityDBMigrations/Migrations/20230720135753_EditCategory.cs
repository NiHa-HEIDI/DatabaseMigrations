using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230720125756)]
    public class EditCategoryTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"UPDATE SUBCATEGORY SET name = ""FlashNews"" where id=1;
               DELETE FROM CATEGORY WHERE name = ""Road works / Traffic"";
               UPDATE SUBCATEGORY SET NAME = ""Road works / Traffic"" WHERE name = ""Alerts"";
               DELETE FROM CATEGORY WHERE NAME =""Defect report"";
               DELETE FROM SUBCATEGORY WHERE name = ""Topic of the day"";
               ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
        }
    }
}
