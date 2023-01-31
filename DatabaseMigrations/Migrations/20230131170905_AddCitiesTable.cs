using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230131170905)]
    public class AddCitiesTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"CREATE TABLE IF NOT EXISTS CITIES(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255)
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS CITIES;";

            Execute.Sql(sql);
        }
    }
}
