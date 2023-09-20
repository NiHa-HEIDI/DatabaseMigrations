using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230525090112)]
    public class AddRequestForumStatus: Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS forumstatus;
                CREATE TABLE forumstatus (
                    id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    name varchar(255)
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS forumstatus;";

            Execute.Sql(sql);
        }
    }
}