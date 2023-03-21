using FluentMigrator;
using System.Data.Common;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230321044807)]
    public class AddColumnCreatedAtListingsTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE listings ADD createdAt DATETIME;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE listings DROP column createdAt;";

            Execute.Sql(sql);
        }
    }
}
