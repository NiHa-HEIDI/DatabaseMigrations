using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20231211101207)]
    public class AddSlotsTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS slots;
               CREATE TABLE slots (
                id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
                appointmentId INT,
                dayId INT,
                startTime DATETIME,
                endTime DATETIME,
                maxBookings INT,
                FOREIGN KEY (appointmentId) REFERENCES appointments(id),
                FOREIGN KEY (dayId) REFERENCES days(id)
            );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS slots;";

            Execute.Sql(sql);
        }
    }
}
