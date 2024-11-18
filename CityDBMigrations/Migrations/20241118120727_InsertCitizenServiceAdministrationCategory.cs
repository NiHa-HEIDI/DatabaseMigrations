using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20241118120727)]
    public class InsertCitizenServiceAdministrationCategory : Migration
    {
        public override void Up()
        {
            string sql =
               @"INSERT IGNORE INTO categories (id, name)
                VALUES
                    (45, 'Bürgerservice Verwaltung');
                ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
        }
    }
}
