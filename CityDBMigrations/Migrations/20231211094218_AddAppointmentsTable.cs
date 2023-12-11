using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20231211094218)]
    public class AddAppointmentsTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS appointments;
               CREATE TABLE appointments (
                    id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    listingsId INT, 
                    FOREIGN KEY(listingsId) REFERENCES listings(id),
                    title VARCHAR(255),
                    description TEXT,
                    startDate DATETIME ,
                    endDate DATETIME,
                    metadata TEXT
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS appointments;";

            Execute.Sql(sql);
        }
    }
}
