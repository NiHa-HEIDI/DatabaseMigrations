using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240222141121)]
    public class AddBookingsTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS bookings;
               CREATE TABLE bookings (
                id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
                appointmentId INT,
                createdAT DATETIME,
                startTime DATETIME,
                endTime DATETIME,
                userId INT,
                guestId INT,
                isGuest BOOLEAN,
                remark TEXT,
                createdBy INT,
                isCreatedByGuest BOOLEAN,
                FOREIGN KEY (appointmentId) REFERENCES appointments(id),
                FOREIGN KEY (guestId) REFERENCES guests(id),
                FOREIGN KEY (userId) REFERENCES users(id)
            );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS bookings;";

            Execute.Sql(sql);
        }
    }
}