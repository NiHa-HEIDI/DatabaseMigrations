using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(2)]
    public class AddUsersTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS USERS;
                CREATE TABLE USERS (
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT, 
	                username varchar(255) NOT NULL,
	                firstname varchar(255) NOT NULL, 
	                lastname varchar(255) NOT NULL,
	                email varchar(255) NOT NULL,
	                phoneNumber varchar(255),
	                image varchar(255), 
	                description varchar(255),
	                website varchar(255),
	                roleId int,
	                FOREIGN KEY (roleId) REFERENCES ROLES(id),
	                CONSTRAINT UC_Username UNIQUE (username),
	                CONSTRAINT UC_Email UNIQUE (email)
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS USERS;";

            Execute.Sql(sql);
        }
    }
}
