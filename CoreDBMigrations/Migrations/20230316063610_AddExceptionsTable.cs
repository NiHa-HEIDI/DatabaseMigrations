using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230316063610)]
    public class AddExceptionsTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS exceptions;
                CREATE TABLE exceptions (
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                message varchar(255),
	                stackTrace varchar(10000),
	                occuredAt DATETIME
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS exceptions;";

            Execute.Sql(sql);
        }
    }
}
