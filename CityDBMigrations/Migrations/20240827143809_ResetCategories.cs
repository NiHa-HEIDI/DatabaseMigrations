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
                    (6, 'offerSearch'),
                    (7, 'NewCitizenInfo'),
                    (8, 'DefectReport'),
                    (9, 'LostAndFound'),
                    (10, 'companyPortaits'),
                    (11, 'carpoolingPublicTransport'),
                    (12, 'Offers'),
                    (13, 'eatOrDrink'),
                    (14, 'rathaus'),
                    (15, 'newsletter'),
                    (16, 'officialnotification'),
                    (17, 'freetimeAndTourisms'),
                    (18, 'AppointmentBooking'),
                    (19, 'DefectReporter'),
                    (20, 'Applicants'),
                    (21, 'Energiedienstleistungen'),
                    (22, 'Internet of Things / IoT'),       
                    (23, 'KommunaleWärmeplanung'),  
                    (24, 'Wasserstoff'),            
                    (25, 'Polls'),
                    (26, 'WorthSeeing'),
                    (27, 'Dekarbonisierung'),       
                    (28, 'Erzeugung'),              
                    (29, 'Handel'),                 
                    (30, 'Fernwärme'),              
                    (31, 'SmartCity'),              
                    (32, 'DynamischerTarif'),       
                    (33, 'Mobilität'),             
                    (34, 'Integration'),            
                    (35, 'DigitaleBürgerservices'),   
                    (36, 'Tourismus'),       
                    (37, 'DigitaleStadtplanung'),   
                    (38, 'Wirtschaftsförderung'),  
                    (39, 'Abfallwirtschaft'),         
                    (40, 'Bürgerbeteiligung'),         
                    (41, 'Highlights'),         
                    (42, 'Project')
                    ;
                ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
        }
    }
}
