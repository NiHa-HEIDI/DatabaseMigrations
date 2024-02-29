using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240222145524)]
    public class AddBookinServiceMappingTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS BookingServiceMapping;
               CREATE TABLE BookingServiceMapping (
                id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
                bookingId INT,
                serviceId INT,
                FOREIGN KEY (bookingId) REFERENCES bookings(id),
                FOREIGN KEY (serviceId) REFERENCES appointmentServices(id)
            );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS BookinServiceMapping;";

            Execute.Sql(sql);
        }
    }
}