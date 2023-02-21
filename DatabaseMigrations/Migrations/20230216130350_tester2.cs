using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230216130350)]
    public class tester2 : Migration
    {
        public override void Up()
        {
            String path = @"Scripts/anything.sql";
            Execute.Script(path);
        }

        public override void Down()
        {
        }
    }
}
