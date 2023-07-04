using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230413095044)]
    public class AddNotification : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS NOTIFICATION;
                CREATE TABLE NOTIFICATION(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    userId int,
                    FOREIGN KEY (userId) REFERENCES USERS(id),
                    typeId int,
                    FOREIGN KEY (typeId) REFERENCES NOTIFICATION_TYPE(id),
                    message varchar(255)
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS NOTIFICATION;";

            Execute.Sql(sql);
        }
    }
}
