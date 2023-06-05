using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230605141232)]
    public class AddHasForumsColumnCitiesTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE FORUMS ADD COLUMN description varchar(10000), ADD COLUMN image varchar(255) ;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
                @"ALTER TABLE FORUMS DROP COLUMN description , DROP COLUMN image ;";

            Execute.Sql(sql);
        }
    }
}
