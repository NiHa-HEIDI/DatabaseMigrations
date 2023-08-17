using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230817130200)]
    public class AddIlzerLand : Migration
    {
        public override void Up()
        {
            string sql =
               @"
               INSERT INTO CITIES (id, name, connectionString) 
               VALUES(13, 'Ilzer Land','server=localhost;user=devuser;password=devpassword;database=heidi_city_1');";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql = @"DELETE FROM CITIES WHERE id = 13;";
            Execute.Sql(sql);
        }
    }
}
