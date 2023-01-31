using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230131143438)]
    public class AddRolesTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"CREATE TABLE IF NOT EXISTS ROLES(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255)
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS ROLES;";

            Execute.Sql(sql);
        }
    }
}
