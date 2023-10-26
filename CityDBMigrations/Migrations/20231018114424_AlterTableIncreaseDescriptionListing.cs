using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20231018114424)]
    public class AlterTableIncreaseDescriptionListing : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE listings modify Description TEXT;
               ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
        }
    }
}
