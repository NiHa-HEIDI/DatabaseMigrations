using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230223052220)]
    public class addSourceTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS source;
                CREATE TABLE source(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255)
                );
                insert into source (name) value (""User entry"");";
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
