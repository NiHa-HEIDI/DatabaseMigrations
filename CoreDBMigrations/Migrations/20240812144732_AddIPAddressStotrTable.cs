

using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240812144732)]
    public class AddIPCloumnToStoreTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE shops ADD ipAddress VARCHAR(16) NOT NULL; ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE shops DROP COLUMN ipAddress;";

            Execute.Sql(sql);
        }
    }
}
