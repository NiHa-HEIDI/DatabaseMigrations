using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20230803144015)]
    public class AddServiceLogsTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS ServiceLogs;
                 CREATE TABLE ServiceLogs(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    inputId int,
                    FOREIGN KEY (inputId) REFERENCES ServiceInput(id),
                    input varchar(1000),
                    startTime DATETIME,
                    endTime DATETIME,
                    stack varchar(1000),
                    serviceId int,
                    statusId int,
                    FOREIGN KEY (statusId) REFERENCES ServiceStatus(id),
                    createdAt DATETIME
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
