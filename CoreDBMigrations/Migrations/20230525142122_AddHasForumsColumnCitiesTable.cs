using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230525142122)]
    public class AddHasForumsColumnCitiesTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE cities ADD COLUMN hasForum bool;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE cities DROP COLUMN hasForum;";

            Execute.Sql(sql);
        }
    }
}
