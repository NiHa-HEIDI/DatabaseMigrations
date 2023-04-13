using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230412072158)]
    public class AddSocialMediaColumnToUser : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE USERS ADD COLUMN socialMedia varchar(255);";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE USERS DROP COLUMN socialMedia;";

            Execute.Sql(sql);
        }
    }
}
