using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240119134025)]
    public class AddCartItems: Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS cartitems;
                CREATE TABLE cartitems (
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    cartId int,
                    productId int,
                    quantity int,
                    FOREIGN KEY (cartId) REFERENCES cart(id) ON DELETE CASCADE,
                    FOREIGN KEY (productId) REFERENCES products(id) ON DELETE CASCADE
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS cartitems;";

            Execute.Sql(sql);
        }
    }
}
