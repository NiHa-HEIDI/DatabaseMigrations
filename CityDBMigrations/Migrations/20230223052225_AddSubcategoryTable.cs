using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230223052225)]
    public class AddSubcategoryTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS subcategory;
                CREATE TABLE subcategory(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255),
                    categoryId int
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS subcategory;";

            Execute.Sql(sql);
        }
    }
}
