using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230720135753)]
    public class EditCategoryTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"INSERT INTO SUBCATEGORY(id, name, categoryId) values (9,""Road works / Traffic"", 1);
               UPDATE LISTINGS SET categoryId=1, subcategoryId=9 where categoryId = 2;
               UPDATE SUBCATEGORY SET name = ""FlashNews"" where id=1;
               DELETE FROM CATEGORIES WHERE id = 2;
               UPDATE LISTINGS SET subcategoryId = 1 where subcategoryId = 2;
               DELETE FROM SUBCATEGORY WHERE id = 2;
               DELETE FROM CATEGORIES WHERE NAME =""Defect report"";
               DELETE FROM SUBCATEGORY WHERE name = ""Topic of the day"";
               INSERT INTO CATEGORIES (name, noOfSubcategories) values (""Eat or Drink"", 0);
               ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
        }
    }
}
