using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230726144955)]
    public class ChnagingCommentsToComment : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE forumcomments RENAME COLUMN comments TO comment;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
                @"";

            Execute.Sql(sql);
        }
    }
}