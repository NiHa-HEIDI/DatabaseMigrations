using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20231124143459)]
    public class AddCoreUserIdColumn : Migration
    {
        public override void Up()
        {
            string sql =
                @"ALTER TABLE users ADD coreUserId int;
                ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE users DROP COLUMN coreUserId;
               ";

            Execute.Sql(sql);
        }
    }
}