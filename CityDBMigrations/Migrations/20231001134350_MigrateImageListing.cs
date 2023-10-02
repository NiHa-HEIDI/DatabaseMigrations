using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20231001134350)]
    public class MigrateImageListing : Migration
    {
        public override void Up()
        {
            string sql =
               @"INSERT INTO Listing_Images (
                    listingId,
                    logo
                )
                SELECT id, logo FROM listings WHERE logo IS NOT NULL AND logo != '';
                UPDATE Listing_Images SET `imageOrder`=1;
                ALTER TABLE listings DROP COLUMN logo;
               ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
             string sql =
               @"ALTER TABLE listings ADD COLUMN logo varchar(255);
               UPDATE listings INNER JOIN Listing_Images ON Listing_Images.listingId = listings.id  SET  listings.logo = Listing_Images.logo WHERE Listing_Images.imageOrder=1;
               ";


            Execute.Sql(sql);
            
        }
    }
}
