using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230605142236)]
    public class AddDescriptionForums : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE forums ADD COLUMN description varchar(10000), ADD COLUMN image varchar(255) ;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
                @"ALTER TABLE forums DROP COLUMN description , DROP COLUMN image ;";

            Execute.Sql(sql);
        }
    }
}