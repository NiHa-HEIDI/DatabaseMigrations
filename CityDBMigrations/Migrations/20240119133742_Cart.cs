using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240119133742)]
    public class AddCart: Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS cart;
                CREATE TABLE cart (
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    userId int,
                    FOREIGN KEY (userId) REFERENCES users(id)
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS cart;";

            Execute.Sql(sql);
        }
    }
}
