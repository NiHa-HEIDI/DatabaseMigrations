using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240223070321)]
    public class AddAppointmentIdInListings : Migration
    {
        public override void Up()
        {
            string sql =
               @"
                ALTER TABLE listings ADD appointmentId INT;
               ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"
               ALTER TABLE listings DROP COLUMN appointmentId;
               ";

            Execute.Sql(sql); 
        }
    }
}
