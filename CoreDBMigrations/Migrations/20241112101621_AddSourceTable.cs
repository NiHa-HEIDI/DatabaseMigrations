using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20241112101621)]
    public class AddSourceTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS source;
                CREATE TABLE source(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255)
                );
                insert into source (name) value (""User entry"");
                insert into source (name) value (""Instagram"");
                insert into source (name) value (""Webscraper"");";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS source;";

            Execute.Sql(sql);
        }
    }
}
