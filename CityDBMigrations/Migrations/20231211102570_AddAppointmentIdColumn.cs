using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20231211102570)]
    public class AddColumnAppointmentId : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE listings ADD appointmentId int,
               ADD CONSTRAINT FK_Listings_Appointments FOREIGN KEY (appointmentId) REFERENCES appointments(id);";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE listings DROP COLUMN appointmentId;";

            Execute.Sql(sql);
        }
    }
}
