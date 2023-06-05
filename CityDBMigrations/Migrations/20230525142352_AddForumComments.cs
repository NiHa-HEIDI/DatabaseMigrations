using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230525142352)]
    public class AddForumComments: Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS ForumComments;
                CREATE TABLE ForumComments (
                    id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    forumId int, 
                    FOREIGN KEY(forumId) REFERENCES FORUMS(id),  
                    postId int, 
                    FOREIGN KEY(postId) REFERENCES ForumPosts(id),  
                    userId int, 
                    FOREIGN KEY(userId) REFERENCES USERS(id),
                    comments varchar(1000),
                    createdAt DATETIME
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS ForumComments;";

            Execute.Sql(sql);
        }
    }
}