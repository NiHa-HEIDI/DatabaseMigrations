using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240612075704)]
    public class AddListingViewCountColumn : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE listings ADD viewCount int NOT NULL DEFAULT 0";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE listings DROP COLUMN viewCount;";

            Execute.Sql(sql);
        }
    }
}