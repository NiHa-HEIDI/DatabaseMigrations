using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20240327134034)]
    public class AddEnabledColumnInAds : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE advertisements ADD enabled BOOLEAN DEFAULT FALSE;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE advertisements DROP COLUMN enabled;";

            Execute.Sql(sql);
        }
    }
}
