using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240209104829)]
    public class UpdateCoreUserIdColumn : Migration
    {
        public override void Up()
        {
            string sql =
                @"
                UPDATE users u
                INNER JOIN heidi_core.user_cityuser_mapping um ON u.id = um.cityUserId
                SET u.coreUserId = um.userId
                WHERE um.cityId = CONVERT(SUBSTRING_INDEX(REVERSE(DATABASE()), '_', 1), UNSIGNED INTEGER);
                ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"
                UPDATE users u set u.coreUserId = NULL;
               ";

            Execute.Sql(sql);
        }
    }
}