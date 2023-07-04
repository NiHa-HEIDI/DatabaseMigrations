using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230614123453)]
    public class AddPdfListings : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE listings ADD COLUMN pdf varchar(255);";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
                @"ALTER TABLE listings DROP COLUMN pdf ;";

            Execute.Sql(sql);
        }
    }
}