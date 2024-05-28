using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20240524052429)]
    public class AddMullKalenderStreetPropertiesHouseTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS mullkalender_street_properties_house;
                 CREATE TABLE mullkalender_street_properties_house(
                    streetId int NOT NULL,
                    houseNumber varchar(255) NOT NULL,
                    propertyId int NOT NULL,
                    FOREIGN KEY (streetId) REFERENCES mullkalender_streets(id),
                    FOREIGN KEY (propertyId) REFERENCES mullkalender_properties(id),
                    UNIQUE (streetId, houseNumber, propertyId)
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS mullkalender_street_properties_house;";

            Execute.Sql(sql);
        }
    }
}
