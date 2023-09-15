using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230802070322)]
    public class AddReportPostsColumn : Migration
    {
        public override void Up()
        {
            string sql =
                @"ALTER TABLE postreports RENAME TO reportedposts;
                  ALTER TABLE reportedposts ADD Reason varchar(255);
                ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE reportedposts DROP COLUMN Reason;
               ";

            Execute.Sql(sql);
        }
    }
}