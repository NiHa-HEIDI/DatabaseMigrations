using FluentMigrator;
using System.Data.Common;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230314080207)]
    public class IncreaseDescriptionColumnSizeListingsTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE heidi_city_1.listings CHANGE COLUMN description description VARCHAR(10000);";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE heidi_city_1.listings CHANGE COLUMN description description VARCHAR(255); ";

            Execute.Sql(sql);
        }
    }
}
