using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230605142237)]
    public class AddIsPrivateForums : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE FORUMS ADD COLUMN isPrivate bool;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
                @"ALTER TABLE FORUMS DROP COLUMN isPrivate;";

            Execute.Sql(sql);
        }
    }
}