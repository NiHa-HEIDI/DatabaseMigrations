using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20240827143809)]
    public class ResetCategories : Migration
    {
        public override void Up()
        {
            string sql =
               @"INSERT IGNORE INTO categories (id, name)
                VALUES 
                    (1, 'News'),
                    (2, 'RoadWorksOrTraffic'),
                    (3, 'Events'),
                    (4, 'Clubs'),
                    (5, 'RegionalProducts'),
                    (6, 'OfferOrSearch'),
                    (7, 'NewCitizenInfo'),
                    (8, 'DefectReport'),
                    (9, 'LostAndFound'),
                    (10, 'CompanyPortraits'),
                    (11, 'CarpoolingOrPublicTransport'),
                    (12, 'Offers'),
                    (13, 'eatOrDrink'),
                    (14, 'rathaus'),
                    (15, 'newsletter'),
                    (16, 'officialnotification'),
                    (17, 'freetimeAndTourisms'),
                    (18, 'AppointmentBooking'),
                    (19, 'DefectReporter'),
                    (20, 'Applicants'),
                    (25, 'Polls'),
                    (26, 'WorthSeeing');
                ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
        }
    }
}
