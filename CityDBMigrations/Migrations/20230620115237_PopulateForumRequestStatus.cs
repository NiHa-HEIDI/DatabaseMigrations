using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230620115237)]
    public class PopulateForumRequestStatus : Migration
    {
        public override void Up()
        {
            string sql =
               @"insert into forumstatus values (1,""Pending""), (2,""Accepted""), (3,""Rejected"");";

            Execute.Sql(sql);
        }

        public override void Down()
        {
        }
    }
}