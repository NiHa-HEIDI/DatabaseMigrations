using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20231010103755)]
    public class AddDefaultColImageListing : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE Listing_Images ADD isDefaultImage boolean not null default 0;
               ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql = @"ALTER TABLE Listing_Images DROP COLUMN isDefaultImage";
            Execute.Sql(sql);
        }
    }
}
