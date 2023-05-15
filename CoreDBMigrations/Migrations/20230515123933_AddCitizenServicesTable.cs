using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230515123933)]
    public class AddCitizenServicesTable: Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS CITIZEN_SERVICES;
                CREATE TABLE CITIZEN_SERVICES(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    cityId int,
                    FOREIGN KEY (cityId) REFERENCES CITIES(id),
                    title varchar(255),
                    image varchar(255),
                    link varchar(255)
                    );";
            Execute.Sql(sql);
        }
        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS CITIZEN_SERVICES;";
            Execute.Sql(sql);
        }
    }
}
