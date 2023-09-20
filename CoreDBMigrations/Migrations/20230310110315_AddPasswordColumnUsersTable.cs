using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230310110315)]
    public class AddPasswordColumnUsersTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE users ADD COLUMN password VARCHAR(255);";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE users DROP COLUMN password;";

            Execute.Sql(sql);
        }
    }
}
