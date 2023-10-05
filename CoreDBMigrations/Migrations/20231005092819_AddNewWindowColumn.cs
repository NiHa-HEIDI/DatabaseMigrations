using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20231005092819)]
    public class AddNewWindowColumn : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE citizen_services ADD isExternalLink BOOLEAN DEFAULT FALSE;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE citizen_services DROP COLUMN isExternalLink;";

            Execute.Sql(sql);
        }
    }
}
