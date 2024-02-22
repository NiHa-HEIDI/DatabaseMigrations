using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240222135739)]
    public class AddAppointmentsTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS appointments;
               CREATE TABLE appointments (
                    id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    userId INT,
                    title VARCHAR(255),
                    description TEXT,
                    startDate DATETIME ,
                    endDate DATETIME,
                    metaData TEXT,
                    FOREIGN KEY (userId) REFERENCES users(id)
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