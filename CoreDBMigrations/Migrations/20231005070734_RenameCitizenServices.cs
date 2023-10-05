using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20231005070734)]
    public class RenameCitizenServices : Migration
    {
        public override void Up()
        {
            string sql =
               @"Alter table citizen_services rename digital_management;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"Alter table digital_management rename citizen_services;";

            Execute.Sql(sql);
        }
    }
}
