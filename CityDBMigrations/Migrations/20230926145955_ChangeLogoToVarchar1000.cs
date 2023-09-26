using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230926145955)]
    public class ChangeLogoToVarchar1000 : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE listings MODIFY COLUMN logo VARCHAR(1000);
               ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
        }
    }
}
