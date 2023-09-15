using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230413095044)]
    public class AddNotification : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS notification;
                CREATE TABLE notification(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    userId int,
                    FOREIGN KEY (userId) REFERENCES users(id),
                    typeId int,
                    FOREIGN KEY (typeId) REFERENCES notification_type(id),
                    message varchar(255)
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS notification;";

            Execute.Sql(sql);
        }
    }
}
