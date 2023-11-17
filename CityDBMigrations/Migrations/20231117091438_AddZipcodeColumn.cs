using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20231117091438)]
    public class AddZipcodeColumn : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE listings add column zipcode INT;
               ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE listings drop column zipcode;
               ";

            Execute.Sql(sql);
        }
    }
}
