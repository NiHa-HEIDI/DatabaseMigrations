using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240119134925)]
    public class AddSellRequests: Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS sellrequests;
                CREATE TABLE sellrequests (
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    userId int,
                    shopId int,
                    title varchar(255),
                    description varchar(255),
                    status int,
                    FOREIGN KEY (userId) REFERENCES users(id),
                    FOREIGN KEY (shopId) REFERENCES shops(id) ON DELETE CASCADE
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS sellrequests;";

            Execute.Sql(sql);
        }
    }
}
