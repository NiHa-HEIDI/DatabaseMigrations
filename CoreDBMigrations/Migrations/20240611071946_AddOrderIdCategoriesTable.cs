using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240611071946)]
    public class AddOrderIdCategoriesTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE categories ADD category_order INT; 
                UPDATE categories SET category_order = id;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE categories DROP COLUMN category_order;";

            Execute.Sql(sql);
        }
    }
}
