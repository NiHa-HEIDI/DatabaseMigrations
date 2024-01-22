using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240122122359)]
    public class AddShowExternalColumn : Migration
    {
        public override void Up()
        {   
            // Adding new colum to listings = showExternal.
            string sql =
               @"ALTER TABLE listings ADD COLUMN showExternal BOOLEAN DEFAULT FALSE;
               ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE listings DROP COLUMN showExternal;
               ";

            Execute.Sql(sql);
        }
    }
}
