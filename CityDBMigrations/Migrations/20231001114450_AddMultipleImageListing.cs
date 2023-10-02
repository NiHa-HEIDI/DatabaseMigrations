using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20231001114450)]
    public class AddMultipleImageListing : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS Listing_Images;
                CREATE TABLE Listing_Images (
                    id int NOT NULL PRIMARY KEY AUTO_INCREMENT, 
                    imageOrder int,
	                listingId int,
                    logo varchar(255),
                    FOREIGN KEY (listingId) REFERENCES listings(id)
                );
               ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
             string sql =
               @"DROP TABLE IF EXISTS Listing_Images;";

            Execute.Sql(sql);
            
        }
    }
}
