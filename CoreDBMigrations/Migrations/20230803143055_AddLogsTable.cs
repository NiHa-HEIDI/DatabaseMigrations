using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20230803143055)]
    public class AddServiceLogsTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS ServiceLogs;
                 CREATE TABLE ServiceLogs(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    startTime DATETIME,
                    endTime DATETIME,
                    stack varchar(1000),
	                status varchar(255),
                    createdAt DATETIME,
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS ServiceLogs;";

            Execute.Sql(sql);
        }
    }
}
