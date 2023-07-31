using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230731083433)]
    public class AddSubcategory : Migration
    {
        public override void Up()
        {
            string sql =
               @"INSERT INTO subcategory (id, name, categoryId) VALUES (10, ""Amtliche Mitteilung"", 1);";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql = @"DELETE FROM subcategory WHERE id = 10;";
            Execute.Sql(sql);
        }
    }
}