using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230920131343)]
    public class AddAccessTokenTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS accesstable;
                CREATE TABLE accesstable(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255),
                    token varchar(1000),
                    serviceid int NOT NULL
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS accesstable;";

            Execute.Sql(sql);
        }
    }
}
