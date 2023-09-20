using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230515123940)]
    public class AddDeviceDetailsRow : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE refreshtokens ADD COLUMN browser varchar(255), ADD COLUMN device varchar(255) ;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE cities DROP COLUMN browser, DROP COLUMN device;";

            Execute.Sql(sql);
        }
    }
}
