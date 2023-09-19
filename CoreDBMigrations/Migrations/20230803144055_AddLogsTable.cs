using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20230803144055)]
    public class AddServiceLogsTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS servicelogs;
                 CREATE TABLE servicelogs(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    inputId int,
                    input varchar(1000),
                    startTime DATETIME,
                    endTime DATETIME,
                    stack varchar(1000),
                    serviceId int,
                    statusId int,
                    FOREIGN KEY (statusId) REFERENCES servicestatus(id),
                    output varchar(5000),
                    createdAt DATETIME
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS servicelogs;";

            Execute.Sql(sql);
        }
    }
}
