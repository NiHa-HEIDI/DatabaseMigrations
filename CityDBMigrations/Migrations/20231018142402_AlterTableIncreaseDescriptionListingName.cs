using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20231018142402)]
    public class AlterTableIncreaseDescriptionListingName : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE listings modify description TEXT;
               ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
        }
    }
}
