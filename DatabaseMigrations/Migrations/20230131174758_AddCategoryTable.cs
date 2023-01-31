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
	                name varchar(255)
                );
                insert into categories (name) values ('Company Portraits');
                insert into categories (name) values ('Construction and Traffic Listings');
                insert into categories (name) values ('Defect Reporter');
                insert into categories (name) values ('Event Listings');
                insert into categories (name) values ('Lost Property Office');
                insert into categories (name) values ('Offer Search');
                insert into categories (name) values ('Regional Products');
                insert into categories (name) values ('Societies Listings');
                insert into categories (name) values ('Warning Messages Listings');";

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
