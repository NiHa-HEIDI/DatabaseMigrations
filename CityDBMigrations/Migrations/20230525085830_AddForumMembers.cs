using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230525085830)]
    public class AddForumMembers: Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS forummembers;
                CREATE TABLE forummembers (
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT, 
                    forumId int, 
                    FOREIGN KEY(forumId) REFERENCES forums(id),    
                    userId int, 
                    FOREIGN KEY(userId) REFERENCES users(id),
                    JoinedAt DATETIME,
                    isAdmin BOOLEAN
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS forummembers;";

            Execute.Sql(sql);
        }
    }
}
