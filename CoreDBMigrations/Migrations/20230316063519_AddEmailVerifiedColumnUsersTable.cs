using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230316063519)]
    public class AddEmailVerifiedColumnUsersTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE users ADD COLUMN emailVerified bool;
                UPDATE users set emailVerified = true where id = 1;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE users DROP COLUMN emailVerified;";

            Execute.Sql(sql);
        }
    }
}
