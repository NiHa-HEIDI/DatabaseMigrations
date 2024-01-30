using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240125133243)]
    public class AddScrapperSource : Migration
    {
        public override void Up()
        {
            string sql =
               @"INSERT INTO source(id, name) values (3,""Scrapper"");";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql = @"DELETE FROM source WHERE id = 3;";
            Execute.Sql(sql);
        }
    }
}
