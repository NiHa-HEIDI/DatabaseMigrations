using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230919153433)]
    public class AddServiceToServiceTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"INSERT INTO services (id, name, isRunning, safeStop, createdAt) VALUES (1, ""Delete Listing"", 0, 0,  date()), (2, ""Upload Insta Post to Listing"", 0, 0,  date());";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql = @"DELETE FROM services WHERE id = 1 AND id = 2;";
            Execute.Sql(sql);
        }
    }
}