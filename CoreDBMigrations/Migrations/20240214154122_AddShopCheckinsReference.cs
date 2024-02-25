using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240214154122)]
    public class AddShopCheckinsReference: Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE shops ADD FOREIGN KEY (checkedIn) REFERENCES shopcheckins(id) ON DELETE CASCADE;"; 
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS shops;";

            Execute.Sql(sql);
        }
    }
}
