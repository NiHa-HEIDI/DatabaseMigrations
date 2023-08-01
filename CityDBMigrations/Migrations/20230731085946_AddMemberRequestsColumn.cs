using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230731085946)]
    public class AddMemberRequestsColumn : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE ForumRequests ADD reason varchar(255);
               ALTER TABLE listings ADD COLUMN expiryDate DATETIME;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql = 
                @"ALTER TABLE ForumRequests DROP COLUMN reason;
                ALTER TABLE listings DROP COLUMN expiryDate ;";
                
            Execute.Sql(sql);
        }
    }
}