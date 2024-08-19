using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240816143012)]
    public class AddUserIdAndMetadataColumns : Migration
    {
        public override void Up()
        {   
            // Adding userId and metadata columns, and setting up the foreign key constraint for userId
            string sql = @"
                ALTER TABLE report_product 
                ADD COLUMN userId int,
                ADD COLUMN metadata varchar(1000);
            ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            // Dropping the userId and metadata columns
            string sql = @"
                ALTER TABLE report_product 
                DROP COLUMN userId,
                DROP COLUMN metadata;
            ";

            Execute.Sql(sql);
        }
    }
}
