using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240430113842)]
    public class ChangeServiceColumn : Migration
    {
        public override void Up()
        {
            string sql =
                @"ALTER TABLE appointmentServices RENAME COLUMN MetaData TO metadata;
                ALTER TABLE bookings RENAME COLUMN createdAT TO createdAt;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE appointmentServices RENAME COLUMN metadata TO MetaData;
               ALTER TABLE bookings RENAME COLUMN createdAt TO createdAT;";

            Execute.Sql(sql);
        }
    }
}