using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20231024121646)]
    public class AlterTableAddUpdatedDateColumn : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE listings ADD COLUMN updatedAt DATETIME;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
        }
    }
}
