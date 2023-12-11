using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20231211102561)]
    public class AddBookingsTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS bookings;
               CREATE TABLE bookings (
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
               @"DROP TABLE IF EXISTS bookings;";

            Execute.Sql(sql);
        }
    }
}
