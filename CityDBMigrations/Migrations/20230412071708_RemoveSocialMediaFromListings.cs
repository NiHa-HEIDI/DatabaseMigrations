using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230412071708)]
    public class RemoveSocialMediaFromListings : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE listings DROP column socialMedia;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE listings ADD column socialMedia;";

            Execute.Sql(sql);
        }
    }
}
