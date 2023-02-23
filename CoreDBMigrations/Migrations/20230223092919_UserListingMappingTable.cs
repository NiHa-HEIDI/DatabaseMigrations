using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230223092919)]
    public class UserListingMapping : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS User_Listing_Mapping;
                CREATE TABLE User_Listing_Mapping (
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT, 
	                userId int,
	                cityId int,
	                listingId int
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS User_Listing_Mapping;";

            Execute.Sql(sql);
        }
    }
}
