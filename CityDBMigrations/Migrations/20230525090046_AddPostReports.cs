using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230525090046)]
    public class AddPostReports: Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS PostReports;
                CREATE TABLE PostReports (
                    id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    forumId int, 
                    FOREIGN KEY(forumId) REFERENCES FORUMS(id),  
                    postId int, 
                    FOREIGN KEY(postId) REFERENCES ForumPosts(id),  
                    userId int, 
                    FOREIGN KEY(userId) REFERENCES USERS(id),
                    createdAt DATETIME
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS PostReports;";

            Execute.Sql(sql);
        }
    }
}