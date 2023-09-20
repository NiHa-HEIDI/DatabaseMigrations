using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230525085759)]
    public class AddForums : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS forums;
                CREATE TABLE forums (
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT, 
	                forumName varchar(255) NOT NULL,
                    createdAt DATETIME
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS forums;";

            Execute.Sql(sql);
        }
    }
}
