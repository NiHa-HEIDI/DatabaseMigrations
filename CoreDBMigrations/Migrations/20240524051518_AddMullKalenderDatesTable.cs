using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20240524051518)]
    public class AddMullKalenderDatesTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS mullkalender_dates;
                 CREATE TABLE mullkalender_dates(
                    dateEpoch int NOT NULL,
                    dateGroup int NOT NULL,
                    UNIQUE (dateEpoch, dateGroup)
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS mullkalender_dates;";

            Execute.Sql(sql);
        }
    }
}
