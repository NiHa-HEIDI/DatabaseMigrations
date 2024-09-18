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
                    (6, 'offerSearch', false, 6),
                    (7, 'NewCitizenInfo', false, 7),
                    (8, 'DefectReport', false, 8),
                    (9, 'LostAndFound', false, 9),
                    (10, 'companyPortaits', false, 10),
                    (11, 'carpoolingPublicTransport', false, 11),
                    (12, 'Offers', false, 12),
                    (13, 'eatOrDrink', false, 13),
                    (14, 'rathaus', false, 14),
                    (15, 'newsletter', false, 15),
                    (16, 'officialnotification', false, 16),
                    (17, 'freetimeAndTourisms', false, 17),
                    (18, 'AppointmentBooking', false, 18),
                    (19, 'DefectReporter', false, 19),
                    (20, 'Applicants', false, 20),
                    (21, 'Energiedienstleistungen', false, 21),
                    (22, 'InternetOfThings', false, 22),
                    (23, 'KommunaleWärmeplanung', false, 23),
                    (24, 'Wasserstoff', false, 24),
                    (25, 'Polls', false, 25),
                    (26, 'WorthSeeing', false, 26),
                    (27, 'Dekarbonisierung', false, 27),
                    (28, 'Erzeugung', false, 28),
                    (29, 'Handel', false, 29),
                    (30, 'Fernwärme', false, 30),
                    (31, 'SmartCity', false, 31),
                    (32, 'DynamischerTarif', false, 32),
                    (33, 'Mobilität', false, 33),
                    (34, 'Integration', false, 34),
                    (35, 'DigitaleBürgerservices', false, 35),
                    (36, 'Tourismus', false, 36),
                    (37, 'DigitaleStadtplanung', false, 37),
                    (38, 'Wirtschaftsförderung', false, 38),
                    (39, 'Abfallwirtschaft', false, 39),
                    (40, 'Bürgerbeteiligung', false, 40),
                    (41, 'Highlights', false, 41),
                    (42, 'Project', false, 42)
                ON DUPLICATE KEY UPDATE
                    name = name,
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
