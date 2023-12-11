using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20231211101206)]
    public class AddSlotsTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS Slots;
               CREATE TABLE Slots (
                id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
                appointmentId INT,
                dayId INT,
                startTime DATETIME,
                endTime DATETIME,
                maxBookings INT,
                FOREIGN KEY (appointmentId) REFERENCES Appointments(id),
                FOREIGN KEY (dayId) REFERENCES Days(id)
            );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS Slots;";

            Execute.Sql(sql);
        }
    }
}
