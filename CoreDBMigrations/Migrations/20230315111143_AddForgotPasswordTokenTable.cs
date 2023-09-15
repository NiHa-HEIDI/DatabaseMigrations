using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230315111143)]
    public class AddForgotPasswordTokenTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS forgot_password_tokens;
                CREATE TABLE forgot_password_tokens (
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
