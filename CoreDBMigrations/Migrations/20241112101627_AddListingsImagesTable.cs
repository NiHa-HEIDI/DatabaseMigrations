using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20241112101627)]
    public class AddListingImagesTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS listing_images;
                CREATE TABLE listing_images (
                    id int NOT NULL PRIMARY KEY AUTO_INCREMENT, 
                    imageOrder int,
	                listingId int,
                    logo varchar(1000),
                    FOREIGN KEY (listingId) REFERENCES listings(id)
                );
               ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
             string sql =
               @"DROP TABLE IF EXISTS listing_images;";

            Execute.Sql(sql);
            
        }
    }
}
