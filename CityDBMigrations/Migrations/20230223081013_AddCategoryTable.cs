using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230223081013)]
    public class AddCategoryTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS CATEGORIES;
                CREATE TABLE IF NOT EXISTS CATEGORIES(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255),
                    noOfSubcategories int DEFAULT 0
                );
                INSERT INTO CATEGORIES (name, noOfSubcategories) values ('News', 8);
                INSERT INTO categories (name) values ('Road works / Traffic'), ('Events / News'), ('Associations'), ('Regional Products'), ('Offer / Search'), ('New citizen info'), ('Waste calendar'), ('Defect report'), ('Lost property office'), ('Company portraits'), ('Corona Info'), ('Carpooling / Public transport'), ('Surveys'), ('Weather'), ('Offers');";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS CATEGORIES;";

            Execute.Sql(sql);
        }
    }
}
