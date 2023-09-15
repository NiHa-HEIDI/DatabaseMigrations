using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230316031848)]
    public class AddVerifyTokenTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS verification_tokens;
                CREATE TABLE verification_tokens (
	                userId int NOT NULL,
	                token varchar(255),
	                expiresAt DATETIME,
	                FOREIGN KEY (userId) REFERENCES users(id),
	                CONSTRAINT UC_Userid UNIQUE (userid)
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS forgot_password_tokens;";

            Execute.Sql(sql);
        }
    }
}
