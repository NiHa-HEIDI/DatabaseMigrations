using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20230313063923)]
    public class AddRefreshTokensTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS refreshtokens;
                 CREATE TABLE refreshtokens(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                userId INT,
	                refreshToken TEXT,
	                sourceAddress varchar(255),
	                FOREIGN KEY (userId) REFERENCES users(id)
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS refreshtokens;";

            Execute.Sql(sql);
        }
    }
}
