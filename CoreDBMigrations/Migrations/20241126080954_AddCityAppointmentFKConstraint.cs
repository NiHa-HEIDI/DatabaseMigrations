using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20241126080954)]
    public class AddCityAppointmentFKConstraint : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE city_appointments ADD CONSTRAINT fk_city_appointments_listings FOREIGN KEY (listingsId) REFERENCES listings(id);";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE city_appointments DROP CONSTRAINT fk_city_appointments_listings;";

            Execute.Sql(sql);
        }
    }
}
