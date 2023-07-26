using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230726142655)]
    public class AcceptNullAsParent : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE forumcomments CHANGE parentId parentId INT NULL;";

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