using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230223092919)]
    public class UserListingMapping : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS user_listing_mapping;
                CREATE TABLE user_listing_mapping (
	                userId int,
	                cityId int,
	                listingId int,
                    UNIQUE KEY `unique_ids` (`userId`,`cityId`,`listingId`)
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS user_listing_mapping;";

            Execute.Sql(sql);
        }
    }
}
