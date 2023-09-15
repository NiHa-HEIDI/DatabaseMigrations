using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230223080923)]
    public class AddRolesTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS roles;
                CREATE TABLE roles(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255)
                );
                INSERT INTO roles values (1, ""Administrator""), (2, ""Department Head""), (3, ""Content Creator"");";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS roles;";

            Execute.Sql(sql);
        }
    }
}
