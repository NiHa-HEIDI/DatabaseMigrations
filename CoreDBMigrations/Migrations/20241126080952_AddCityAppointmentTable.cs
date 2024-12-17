using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20241126080952)]
    public class AddCityAppointmentTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS city_appointments;
               CREATE TABLE city_appointments (
                    id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    listingsId INT, 
                    title VARCHAR(255),
                    description TEXT,
                    startDate DATETIME,
                    endDate DATETIME,
                    metadata TEXT
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS city_appointments;";

            Execute.Sql(sql);
        }
    }
}
