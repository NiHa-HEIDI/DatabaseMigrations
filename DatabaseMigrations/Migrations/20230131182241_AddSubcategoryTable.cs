using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230131182241)]
    public class AddSubcategoryTable : Migration
    {
        public override void Up()
        {
            string sql =
                @"CREATE TABLE IF NOT EXISTS subcategories(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255),
                    categoryId int,
                    FOREIGN KEY(categoryId) REFERENCES categories(id)
                );
                insert into subcategories (name,categoryId) values ('Newsflash',1);
                insert into subcategories (name,categoryId) values ('Alerts',1);
                insert into subcategories (name,categoryId) values ('Politics',1);
                insert into subcategories (name,categoryId) values ('Economy',1);
                insert into subcategories (name,categoryId) values ('Sports',1);
                insert into subcategories (name,categoryId) values ('Topic of the day',1);
                insert into subcategories (name,categoryId) values ('Local',1);
                insert into subcategories (name,categoryId) values ('ClubsNews',1);";

            Execute.Sql(sql);
        }

        public override void Down()
        {
        }
    }
}
