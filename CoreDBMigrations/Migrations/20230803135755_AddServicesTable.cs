using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20230803135755)]
    public class AddServicesTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS Services;
                 CREATE TABLE Services(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255),
                    isRunning BOOLEAN,
                    safeStop BOOLEAN,
                    createdAt DATETIME
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS Services;";

            Execute.Sql(sql);
        }
    }
}
