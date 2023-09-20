using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230413073042)]
    public class AddSubcategoryTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS subcategory;
                CREATE TABLE subcategory(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255),
                    categoryId int,
                    FOREIGN KEY (categoryId) REFERENCES categories(id)
                );
                insert into subcategory (name, categoryId) values (""Newsflash"",1),(""Alerts"",1),(""Politics"",1),(""Economy"",1),(""Sport"",1),(""Topic of the day"",1),(""Local"",1),(""Club News"",1);";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS subcategory;";

            Execute.Sql(sql);
        }
    }
}
