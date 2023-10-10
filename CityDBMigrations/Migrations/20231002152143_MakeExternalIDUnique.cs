using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20231002152143)]
    public class MakeExternalIDUnique : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE listings ADD UNIQUE (externalId);
               ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
        }
    }
}
