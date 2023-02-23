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
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT, 
	                userId int,
	                cityId int,
	                cityUserId int
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
