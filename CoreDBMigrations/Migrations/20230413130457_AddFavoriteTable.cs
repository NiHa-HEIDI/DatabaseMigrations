using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230413130457)]
    public class AddFavoriteTable: Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS FAVORITES;
                CREATE TABLE FAVORITES(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    userId int,
                    FOREIGN KEY (userId) REFERENCES USERS(id),
                    cityId int,
                    FOREIGN KEY (cityId) REFERENCES  CITIES(id),
                    listingId int
                    );";
            Execute.Sql(sql);
        }
        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS FAVORITES;";
            Execute.Sql(sql);
        }
    }
}
