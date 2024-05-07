using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20240507101612)]
    public class AddServiceIdInBookingTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE bookings ADD serviceId INT;
                 ALTER TABLE bookings ADD FOREIGN KEY (serviceId) REFERENCES appointmentServices(id);";

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
