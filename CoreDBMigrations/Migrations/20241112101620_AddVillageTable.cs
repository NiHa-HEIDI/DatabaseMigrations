using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20241112101620)]
    public class AddVillageTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS village;
                CREATE TABLE village(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255),
                    cityId INT,
                    FOREIGN KEY(cityId) REFERENCES cities(id)
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS village;";

            Execute.Sql(sql);
        }
    }
}