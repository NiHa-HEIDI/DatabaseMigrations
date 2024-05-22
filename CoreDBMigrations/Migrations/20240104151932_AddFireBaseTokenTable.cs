using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20240104151932)]
    public class AddFireBaseTokenTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"CREATE TABLE firebase_token (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    userId INT,
                    FOREIGN KEY (userId) REFERENCES users(id),
                    firebaseToken VARCHAR(1000),
                    createdAt DATETIME,
                    deviceAddress VARCHAR(255)
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS firebase_token;";

            Execute.Sql(sql);
        }
    }
}
