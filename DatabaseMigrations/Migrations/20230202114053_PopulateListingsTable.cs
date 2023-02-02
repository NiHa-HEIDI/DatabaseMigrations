using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230202114053)]
    public class PopulateListingsTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"
                insert into listings (userId, title, place,description,socialMedia,media,categoryId,address,email,phone,website, price,discountPrice,logo,statusId,sourceId,longitude,lattitude,cityId,startDate,endDate) values (
                1,'1989 World Tour', 'Berlin','concert','www.instagram.com','photo.link',4,'Lange strasse, Berlin road', 'event@example.com','+49152323221', 'www.eventregister.com',250,230.5,'logo.link',1,2,245.65,22.456,1,'2015-04-05 20:00:45','2015-04-03 14:00:45');
                ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS listings;";

            Execute.Sql(sql);
        }
    }
}
