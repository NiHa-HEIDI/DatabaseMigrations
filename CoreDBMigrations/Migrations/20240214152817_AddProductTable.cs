using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240214152817)]
    public class AddProductTable: Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS products;
                CREATE TABLE products (
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    createdAt DATETIME,
                    updatedAt DATETIME,
                    deletedAt DATETIME,
                    title varchar(255),
                    description varchar(255),
                    price double,
                    tax double,
                    inventory int,
                    minCount int,
                    meta varchar(255),
                    isActive boolean,
                    archived boolean,
                    sellerId int,
                    deletedBy int,
                    FOREIGN KEY (sellerId) REFERENCES sellers(id) ON DELETE CASCADE
                    FOREIGN KEY (deletedBy) REFERENCES users(id)
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS products CASCADE;";

            Execute.Sql(sql);
        }
    }
}