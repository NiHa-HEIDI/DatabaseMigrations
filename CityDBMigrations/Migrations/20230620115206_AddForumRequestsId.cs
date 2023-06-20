using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230620115206)]
    public class AddForumRequestsId : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE ForumRequests ADD COLUMN id int NOT NULL PRIMARY KEY AUTO_INCREMENT;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
                @"ALTER TABLE ForumRequests DROP COLUMN int;";

            Execute.Sql(sql);
        }
    }
}