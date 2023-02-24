using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230223091714)]
    public class UserCityUserMapping : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS User_CityUser_Mapping;
                CREATE TABLE User_CityUser_Mapping (
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
               @"DROP TABLE IF EXISTS User_CityUser_Mapping;";

            Execute.Sql(sql);
        }
    }
}
