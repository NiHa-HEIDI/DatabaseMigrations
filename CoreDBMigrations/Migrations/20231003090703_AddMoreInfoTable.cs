using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20231003090703)]
    public class AddMoreInfoTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS moreinfo;
                 CREATE TABLE moreinfo(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                title varchar(255) NOT NULL,
	                link varchar(255) NOT NULL,
                    isPdf bool
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS moreinfo;";

            Execute.Sql(sql);
        }
    }
}
