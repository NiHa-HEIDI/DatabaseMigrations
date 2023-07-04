using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230223043255)]
    public class AddVillageTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS village;
                CREATE TABLE village(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                name varchar(255)
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS VILLAGE;";

            Execute.Sql(sql);
        }
    }
}
