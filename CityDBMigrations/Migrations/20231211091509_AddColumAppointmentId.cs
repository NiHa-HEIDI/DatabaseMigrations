using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20231211091509)]
    public class AddColumnAppointmentId : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE listings ADD appointmentId int;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE listings DROP COLUMN appointmentId;";

            Execute.Sql(sql);
        }
    }
}
