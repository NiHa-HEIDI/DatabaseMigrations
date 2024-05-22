using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240416124200)]
    public class AddLastShownColumnAdTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE advertisements ADD lastShown DATETIME; ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE advertisements DROP COLUMN lastShown;";

            Execute.Sql(sql);
        }
    }
}
