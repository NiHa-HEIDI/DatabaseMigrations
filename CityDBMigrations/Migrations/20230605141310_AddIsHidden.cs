using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230605141310)]
    public class AddHasForumsColumnCitiesTable : Migration
    {
        public override void Up()
        {
            string sql =
                @"ALTER TABLE ForumPosts RENAME COLUMN isHide TO isHidden ;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE ForumPosts DROP isHidden ;";

            Execute.Sql(sql);
        }
    }
}
