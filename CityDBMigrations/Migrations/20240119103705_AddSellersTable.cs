using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240119103705)]
    public class AddSellersTable: Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS sellers;
                CREATE TABLE sellers (
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT, 
                    createdAt DATETIME,
                    updatedAt DATETIME,
                    deletedAt DATETIME,
                    shopId int,
                    userId int,
                    description varchar(255),
                    FOREIGN KEY (shopId) REFERENCES shops(id) ON DELETE CASCADE,
                    FOREIGN KEY (userId) REFERENCES users(id)
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS sellers;";

            Execute.Sql(sql);
        }
    }
}
