using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230605142154)]
    public class AddIsHidden : Migration
    {
        public override void Up()
        {
            string sql =
                @"ALTER TABLE forumposts RENAME COLUMN isHide TO isHidden ;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE forumposts DROP COLUMN isHidden ;";

            Execute.Sql(sql);
        }
    }
}