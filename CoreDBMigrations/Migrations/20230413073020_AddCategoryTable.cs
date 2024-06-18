using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230413073020)]
    public class AddCategoryTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS categories;
                CREATE TABLE IF NOT EXISTS categories(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255),
                    noOfSubcategories int DEFAULT 0
                );
                INSERT INTO categories (name, noOfSubcategories) values ('News', 8);
                INSERT INTO categories (id, name) values (25, 'Polls');
                INSERT INTO categories (name) values ('Road works / Traffic'), ('Events'), ('Clubs'), ('Regional Products'), ('Offer / Search'), ('New citizen info'), ('Defect report'), ('Lost and Found'), ('Company portraits'), ('Carpooling / Public transport'), ('Offers');
                ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS categories;";

            Execute.Sql(sql);
        }
    }
}
