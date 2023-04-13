using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230413091522)]
    public class AddNotificationType : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS NOTIFICATION_TYPE;
                CREATE TABLE NOTIFICATION_TYPE(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255)
                );
                insert into NOTIFICATION_TYPE values (1,""Listing"");";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS NOTIFICATION_TYPE;";

            Execute.Sql(sql);
        }
    }
}
