using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240522074110)]
    public class UpdateWebsiteSize : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE listings DROP INDEX externalId;
               ALTER TABLE listings MODIFY COLUMN externalId TEXT, MODIFY COLUMN website TEXT;
               CREATE INDEX externalId ON listings (externalId(255));";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE listings
                 MODIFY COLUMN externalId VARCHAR(255);
                 ALTER TABLE listings
                 MODIFY COLUMN website VARCHAR(255);";


            Execute.Sql(sql);
        }
    }
}