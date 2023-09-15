using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230413091522)]
    public class AddNotificationType : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS notification_type;
                CREATE TABLE notification_type(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255)
                );
                insert into notification_type values (1,""Listing"");";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS notification_type;";

            Execute.Sql(sql);
        }
    }
}
