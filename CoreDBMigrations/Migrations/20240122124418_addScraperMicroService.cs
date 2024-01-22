using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240122124418)]
    public class AddWebScraperToServiceTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"INSERT INTO services (id, name, isRunning, safeStop, createdAt) VALUES (3, ""Web Scraper"", 0, 0,  UTC_TIMESTAMP);";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql = @"DELETE FROM services WHERE id = 3;";
            Execute.Sql(sql);
        }
    }
}