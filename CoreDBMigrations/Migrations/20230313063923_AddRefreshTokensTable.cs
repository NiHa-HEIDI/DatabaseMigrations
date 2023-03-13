using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20230313063923)]
    public class AddRefreshTokensTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS REFRESHTOKENS;
                 CREATE TABLE REFRESHTOKENS(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                userId INT,
	                refreshToken varchar(255),
	                sourceAddress varchar(255),
	                FOREIGN KEY (userId) REFERENCES USERS(id)
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS REFRESHTOKENS;";

            Execute.Sql(sql);
        }
    }
}
