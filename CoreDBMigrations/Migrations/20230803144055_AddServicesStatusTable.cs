using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230803144015)]
    public class AddServiceStatusTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS ServiceStatus;
                CREATE TABLE ServiceStatus(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255)
                );
                insert into status values (1,""Queued""), (2,""Running""), (3,""Success""), (4,""Failed"";";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS ServiceStatus;";

            Execute.Sql(sql);
        }
    }
}
