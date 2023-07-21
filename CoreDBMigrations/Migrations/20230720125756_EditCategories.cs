using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230720125756)]
    public class EditCategoriesTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"INSERT INTO SUBCATEGORY(id, name, categoryId) values (9,""Road works / Traffic"", 1);
               UPDATE SUBCATEGORY SET name = ""FlashNews"" where id=1;
               DELETE FROM CATEGORIES WHERE name = ""Road works / Traffic"";
               UPDATE SUBCATEGORY SET NAME = ""Road works / Traffic"" WHERE name = ""Alerts"";
               DELETE FROM CATEGORIES WHERE NAME =""Defect report"";
               DELETE FROM SUBCATEGORY WHERE name = ""Topic of the day"";
               INSERT INTO CATEGORIES (name, noOfSubcategories) values (""Eat or Drink"", 0);
               ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
        }
    }
}
