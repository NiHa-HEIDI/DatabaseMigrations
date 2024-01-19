using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240119094101)]
    public class AddShops: Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS shops;
                CREATE TABLE shops (
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT, 
                    name varchar(255),
                    address varchar(255),
                    latitude double,
                    longitude double,
                    description varchar(255),
                    checkedInUser int,
                    FOREIGN KEY (checkedInUser) REFERENCES users(id)
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS shops;";

            Execute.Sql(sql);
        }
    }
}
