using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240119103109)]
    public class AddOwners: Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS owners;
                CREATE TABLE owners (
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT, 
                    shopId int,
                    userId int,
                    FOREIGN KEY (shopId) REFERENCES shops(id) ON DELETE CASCADE,
                    FOREIGN KEY (userId) REFERENCES users(id)
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS owners;";

            Execute.Sql(sql);
        }
    }
}
