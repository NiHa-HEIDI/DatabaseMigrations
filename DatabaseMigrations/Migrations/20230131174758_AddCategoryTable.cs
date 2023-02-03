using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230131174758)]
    public class AddCategoryTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"CREATE TABLE IF NOT EXISTS categories(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255),
                    noOfSubcategories int DEFAULT 0
                );
                insert into categories (name, noOfSubcategories) values ('News', 8);
                insert into categories (name) values ('Road works / Traffic');
                insert into categories (name) values ('Events / News');
                insert into categories (name) values ('Associations');
                insert into categories (name) values ('Regional Products');
                insert into categories (name) values ('Offer / Search');
                insert into categories (name) values ('New citizen info');
                insert into categories (name) values ('Waste calendar ');
                insert into categories (name) values ('Defect report ');
                insert into categories (name) values ('Lost property office ');
                insert into categories (name) values ('Company portraits ');
                insert into categories (name) values ('Corona Info  ');
                insert into categories (name) values ('Carpooling / Public transport ');
                insert into categories (name) values ('Surveys ');
                insert into categories (name) values ('Weather ');
                insert into categories (name) values ('Offers ');";

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
