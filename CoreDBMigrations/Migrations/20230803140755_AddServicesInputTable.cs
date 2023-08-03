using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20230803135755)]
    public class AddServiceInputTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS ServiceInput;
                 CREATE TABLE ServiceInput(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    input varchar(1000) NOT NULL,
	                serviceId int NOT NULL,
                    retryLimit int NOT NULL,
                    createdAt DATETIME
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS ServiceInput;";

            Execute.Sql(sql);
        }
    }
}
