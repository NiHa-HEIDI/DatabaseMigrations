using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230720125756)]
    public class EditCategoriesTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"INSERT INTO subcategory(id, name, categoryId) values (9,""Road works / Traffic"", 1);
               UPDATE subcategory SET name = ""FlashNews"" where id=1;
               DELETE FROM categories WHERE id = 2;
               DELETE FROM subcategory WHERE id = 2;
               DELETE FROM categories WHERE NAME =""Defect report"";
               DELETE FROM subcategory WHERE name = ""Topic of the day"";
               INSERT INTO categories (name, noOfSubcategories) values (""Eat or Drink"", 0);
               ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
        }
    }
}
