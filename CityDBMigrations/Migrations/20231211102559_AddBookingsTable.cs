using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20231211102559)]
    public class AddBookingsTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS Bookings;
               CREATE TABLE Bookings (
                id INT PRIMARY KEY NOT NULL,
                slotId INT,
                userId INT,
                guestId INT,
                isGuest BOOLEAN,
                description TEXT,
                FOREIGN KEY (slotId) REFERENCES Slots(id),
                FOREIGN KEY (guestId) REFERENCES Guests(id),
                FOREIGN KEY (userId) REFERENCES users(id)
            );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS Bookings;";

            Execute.Sql(sql);
        }
    }
}
