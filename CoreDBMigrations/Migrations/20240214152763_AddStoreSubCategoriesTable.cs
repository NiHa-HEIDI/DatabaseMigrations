using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240214152763)]
    public class AddStoreSubCategoriesTable: Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS store_sub_categories;
                CREATE TABLE store_sub_categories (
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    name varchar(255),
                    description varchar(255),
                    categoryId int,
                    FOREIGN KEY (categoryId) REFERENCES store_categories(id)
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS store_sub_categories;";
            Execute.Sql(sql);
        }
    }
}
