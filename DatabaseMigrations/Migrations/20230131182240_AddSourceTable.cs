using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230131182240)]
    public class AddSourceTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"CREATE TABLE IF NOT EXISTS sources(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255)
                );
                insert into sources (name) values ('User Entry')";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS sources;";

            Execute.Sql(sql);
        }
    }
}
