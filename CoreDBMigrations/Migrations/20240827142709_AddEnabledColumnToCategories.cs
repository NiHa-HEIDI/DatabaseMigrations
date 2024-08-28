using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20240827142709)]
    public class AddEnabledColumnToCategories : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE categories ADD COLUMN isEnabled bool;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
                @"ALTER TABLE categories DROP COLUMN isEnabled;";

            Execute.Sql(sql);
        }
    }
}
