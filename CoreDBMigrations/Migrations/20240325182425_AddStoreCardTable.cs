using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240325182425)]
    public class AddCardTable: Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS store_card;
                CREATE TABLE store_card (
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    createdAt DATETIME,
                    updatedAt DATETIME,
                    deletedAt DATETIME,
                    status int,
                    userId int,
                    balance double,
                    expiryMonth int,
                    expiryYear int,
                    FOREIGN KEY (userId) REFERENCES users(id)
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS store_card;";

            Execute.Sql(sql);
        }
    }
}
