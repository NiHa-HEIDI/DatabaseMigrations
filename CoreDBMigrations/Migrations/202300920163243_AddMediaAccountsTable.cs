using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20230920163243)]
    public class AddMediaAccountsTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS mediaaccount;
                 CREATE TABLE mediaaccount(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                accountid int NOT NULL,
                    cityid int NOT NULL,
                    name varchar(255),
	                acoounttype varchar(255),
                    metadata varchar(1000)
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS mediaaccount;";

            Execute.Sql(sql);
        }
    }
}
