using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20240827143809)]
    public class ResetCategories : Migration
    {
        public override void Up()
        {
            string sql =
               @"INSERT INTO categories (id, name, isEnabled, category_order)
                VALUES 
                    (1, 'News', false, 1),
                    (2, 'RoadWorksOrTraffic', false, 2),
                    (3, 'Events', false, 3),
                    (4, 'Clubs', false, 4),
                    (5, 'RegionalProducts', false, 5),
                    (6, 'OfferOrSearch', false, 6),
                    (7, 'NewCitizenInfo', false, 7),
                    (8, 'DefectReport', false, 8),
                    (9, 'LostAndFound', false, 9),
                    (10, 'CompanyPortraits', false, 10),
                    (11, 'CarpoolingOrPublicTransport', false, 11),
                    (12, 'Offers', false, 12),
                    (13, 'eatOrDrink', false, 13),
                    (14, 'rathaus', false, 14),
                    (15, 'newsletter', false, 15),
                    (16, 'officialnotification', false, 16),
                    (17, 'freetimeAndTourisms', false, 17),
                    (18, 'AppointmentBooking', false, 18),
                    (19, 'DefectReporter', false, 19),
                    (20, 'Applicants', false, 20),
                    (25, 'Polls', false, 25),
                    (26, 'WorthSeeing', false, 26)
                ON DUPLICATE KEY UPDATE
                    isEnabled = true,
                    category_order = category_order;
                ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
        }
    }
}
