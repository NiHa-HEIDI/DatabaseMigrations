using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20231005070735)]
    public class AddCitizenServiceTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"CREATE TABLE citizen_services (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    title VARCHAR(255),
                    link VARCHAR(255),
                    image VARCHAR(255)
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS citizen_services;";

            Execute.Sql(sql);
        }
    }
}
