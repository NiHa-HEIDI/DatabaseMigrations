using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230803143055)]
    public class AddServiceStatusTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS servicestatus;
                CREATE TABLE servicestatus(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255)
                );
                insert into servicestatus values (1,""Queued""), (2,""Running""), (3,""Success""), (4,""Failed"");";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS servicestatus;";

            Execute.Sql(sql);
        }
    }
}
