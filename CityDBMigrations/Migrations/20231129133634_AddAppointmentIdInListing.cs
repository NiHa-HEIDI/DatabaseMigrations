using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20231129133634)]
    public class AddAppointmentIdToListing : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE listings ADD COLUMN appotinmentId int;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
                @"ALTER TABLE listings DROP COLUMN appotinmentId;";

            Execute.Sql(sql);
        }
    }
}