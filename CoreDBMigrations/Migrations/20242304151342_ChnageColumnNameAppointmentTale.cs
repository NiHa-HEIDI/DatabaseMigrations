using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240423151342)]
    public class ChangeColumnNameMetaData : Migration
    {
        public override void Up()
        {
            string sql =
                @"ALTER TABLE appointments RENAME COLUMN metaData TO metadata;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE appointments RENAME COLUMN metadata TO metaData;";

            Execute.Sql(sql);
        }
    }
}