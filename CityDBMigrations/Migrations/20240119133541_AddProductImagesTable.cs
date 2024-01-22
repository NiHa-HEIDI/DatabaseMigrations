using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240119133541)]
    public class AddProductImages: Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS productimages;
                CREATE TABLE productimages (
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    productId int,
                    sequence int,
                    url varchar(255),
                    FOREIGN KEY (productId) REFERENCES products(id) ON DELETE CASCADE
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS productimages;";

            Execute.Sql(sql);
        }
    }
}
