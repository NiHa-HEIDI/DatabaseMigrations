using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230216124005)]
    public class filename : Migration
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
