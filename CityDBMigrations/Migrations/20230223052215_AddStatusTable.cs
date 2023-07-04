using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230223052215)]
    public class AddStatusTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS status;
                CREATE TABLE status(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255)
                );
                insert into status values (1,""Active""), (2,""Inactive""), (3,""Pending"");";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS status;";

            Execute.Sql(sql);
        }
    }
}
