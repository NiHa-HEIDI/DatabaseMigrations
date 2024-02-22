using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240222135204)]
    public class DropAppointmentRelatedTables : Migration
    {
        public override void Up()
        {
            string sql =
               @" ALTER TABLE listings DROP FOREIGN KEY `FK_Listings_Appointments`;
                ALTER TABLE listings DROP COLUMN appointmentId;
                DROP TABLE IF EXISTS bookings;
                DROP TABLE IF EXISTS guests;
                DROP TABLE IF EXISTS slots;
                DROP TABLE IF EXISTS appointments;
                DROP TABLE IF EXISTS days;
                ALTER TABLE listings ADD appointmentId INT;
               ";

            Execute.Sql(sql);
        }

        public override void Down()
        {   
        }
    }
}
