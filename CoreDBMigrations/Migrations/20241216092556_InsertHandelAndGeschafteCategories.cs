using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20241216092556)]
    public class InsertHandelAndGeschafteCategories : Migration
    {
        public override void Up()
        {
            string sql =
               @"INSERT INTO categories (id, name, isEnabled, category_order)
                VALUES 
                    (45, 'Handel', false, 45),
                    (46, 'Geschäfte', false, 46),
                    (47, 'Dienstleister', false, 47)
                ON DUPLICATE KEY UPDATE
                    name = name,
                    isEnabled = true,
                    category_order = category_order;
                INSERT INTO subcategory (id, name, categoryId)
                VALUES
                    (12, 'Handwerk', 47),
                    (13, 'Gesundheit', 47),
                    (14, 'Immobilien', 47),
                    (15, 'Finanzen', 47);
                ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"
                DELETE FROM subcategory WHERE id IN (12, 13, 14, 15);
                DELETE FROM categories WHERE id IN (45, 46, 47);
                ";
            Execute.Sql(sql);


        }
    }
}
