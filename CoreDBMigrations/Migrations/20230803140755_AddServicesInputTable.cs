using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20230803135855)]
    public class AddServiceInputTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS serviceinput;
                 CREATE TABLE serviceinput(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    input varchar(1000) NOT NULL,
                    serviceId int,
                    FOREIGN KEY (serviceId) REFERENCES services(id),
                    startAfter DATETIME,
                    frequency int,
                    failureCount int,
                    retryLimit int NOT NULL,
                    createdAt DATETIME
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS serviceinput;";

            Execute.Sql(sql);
        }
    }
}
