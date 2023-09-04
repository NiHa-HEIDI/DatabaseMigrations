using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230802070322)]
    public class AddReportPostsColumn : Migration
    {
        public override void Up()
        {
            string sql =
                @"ALTER TABLE PostReports RENAME TO ReportedPosts;
                  ALTER TABLE ReportedPosts ADD Reason varchar(255);
                ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE ReportedPosts DROP COLUMN Reason;
               ";

            Execute.Sql(sql);
        }
    }
}