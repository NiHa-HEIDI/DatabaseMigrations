using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240228091750)]
    public class RenameDigitalManagementAddNewColumn : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE digital_management RENAME citizen_service_data;
               ALTER TABLE citizen_service_data ADD citizenServiceId INT; ";


            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE citizen_service_data DROP COLUMN citizenServiceId;
               ALTER TABLE citizen_service_data RENAME digital_management;";

            Execute.Sql(sql);
        }
    }
}