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
                WHERE um.cityId = CAST(SUBSTRING_INDEX(SUBSTRING_INDEX(DATABASE(), '_', -1), '_', 1) AS UNSIGNED INTEGER);
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