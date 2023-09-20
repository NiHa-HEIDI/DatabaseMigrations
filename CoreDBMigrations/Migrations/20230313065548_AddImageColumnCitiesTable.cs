using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230313065548)]
    public class AddImageColumnCitiesTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE cities ADD COLUMN image VARCHAR(255);";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE cities DROP COLUMN image;";

            Execute.Sql(sql);
        }
    }
}
