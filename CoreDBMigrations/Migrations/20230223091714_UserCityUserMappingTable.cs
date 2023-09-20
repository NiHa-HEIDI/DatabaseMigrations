using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230223091714)]
    public class UserCityUserMapping : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS user_cityuser_mapping;
                CREATE TABLE user_cityuser_mapping (
	                userId int,
	                cityId int,
	                cityUserId int,
                    UNIQUE KEY `unique_ids` (`userId`,`cityId`,`cityUserId`)
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS user_cityuser_mapping;";

            Execute.Sql(sql);
        }
    }
}
