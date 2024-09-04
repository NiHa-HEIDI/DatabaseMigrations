using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20240701054843)]
    public class AddForumChatTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS forum_chat;
                 CREATE TABLE forum_chat(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    senderId int NOT NULL,
                    forumId int NOT NULL,
                    cityId int NOT NULL,
                    message varchar(1000) NOT NULL,
                    messageType int NOT NULL,
                    createdAt datetime NOT NULL,
                    deletedAt datetime,
                    FOREIGN KEY (senderId) REFERENCES users(id),
                    FOREIGN KEY (cityId) REFERENCES cities(id)
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS forum_chat;";

            Execute.Sql(sql);
        }
    }
}
