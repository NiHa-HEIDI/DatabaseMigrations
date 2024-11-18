using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20241118120727)]
    public class InsertCitizenServiceAdministrationCategory : Migration
    {
        public override void Up()
        {
            string sql =
               @"INSERT INTO categories (id, name, isEnabled, category_order)
                VALUES 
                    (45, 'Bürgerservice Verwaltung', false, 45)
                ON DUPLICATE KEY UPDATE
                    name = name,
                    isEnabled = true,
                    category_order = category_order;
                ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
        }
    }
}
