using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240416075746)]
    public class Add_MS_accountTypeIdColumn : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE mediaaccount ADD accountTypeId INT,
               ADD CONSTRAINT FK_accountTypeId FOREIGN KEY (accountTypeId) REFERENCES services (id);";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE mediaaccount DROP CONSTRAINT FK_accountTypeId;
               ALTER TABLE mediaaccount DROP COLUMN accountTypeId;";

            Execute.Sql(sql);
        }
    }
}
