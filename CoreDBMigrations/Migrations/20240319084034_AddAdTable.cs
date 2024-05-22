using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20240319084034)]
    public class AddAdTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"CREATE TABLE advertisements (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    cityId INT,
                    image VARCHAR(255),
                    link VARCHAR(255),
                    createdAt DATETIME
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS advertisements;";

            Execute.Sql(sql);
        }
    }
}
