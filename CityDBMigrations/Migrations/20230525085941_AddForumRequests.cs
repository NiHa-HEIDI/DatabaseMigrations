using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230525090909)]
    public class AddForumRequests: Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS ForumRequests;
                CREATE TABLE ForumRequests (
                    forumId int, 
                    FOREIGN KEY(forumId) REFERENCES FORUMS(id),    
                    userId int, 
                    FOREIGN KEY(userId) REFERENCES USERS(id),
                    statusId int,
                    FOREIGN KEY(statusId) REFERENCES ForumStatus(id),
                    createdAt DATETIME,
                    updatedAt DATETIME
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS ForumRequests;";

            Execute.Sql(sql);
        }
    }
}