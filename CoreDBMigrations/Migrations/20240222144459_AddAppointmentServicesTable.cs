using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240222144459)]
    public class AddAppointmentServicesTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS appointmentServices;
               CREATE TABLE appointmentServices (
                id INT PRIMARY KEY NOT NULL,
                appointmentId INT,
                name VARCHAR(255),
                userId INT,
                duration INT,
                slotSameAsAppointment BOOLEAN,
                MetaData TEXT,
                FOREIGN KEY (appointmentId) REFERENCES appointments(id),
                FOREIGN KEY (userId) REFERENCES users(id)
            );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS appointmentServices;";

            Execute.Sql(sql);
        }
    }
}