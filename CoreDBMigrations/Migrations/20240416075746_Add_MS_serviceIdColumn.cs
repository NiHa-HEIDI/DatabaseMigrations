using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240416075746)]
    public class Add_MS_serviceIdColumn : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE mediaaccount ADD serviceId INT,
               ADD CONSTRAINT FK_serviceId FOREIGN KEY (serviceId) REFERENCES services (id);
               ALTER TABLE mediaaccount DROP COLUMN acoounttype; ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE mediaaccount DROP CONSTRAINT FK_serviceId;
               ALTER TABLE mediaaccount DROP COLUMN serviceId;";

            Execute.Sql(sql);
        }
    }
}
