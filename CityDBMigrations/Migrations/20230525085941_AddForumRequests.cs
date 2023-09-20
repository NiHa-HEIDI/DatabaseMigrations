using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230525090909)]
    public class AddForumRequests: Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS forumrequests;
                CREATE TABLE forumrequests (
                    forumId int, 
                    FOREIGN KEY(forumId) REFERENCES forums(id),    
                    userId int, 
                    FOREIGN KEY(userId) REFERENCES users(id),
                    statusId int,
                    FOREIGN KEY(statusId) REFERENCES forumstatus(id),
                    createdAt DATETIME,
                    updatedAt DATETIME
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS forumrequests;";

            Execute.Sql(sql);
        }
    }
}