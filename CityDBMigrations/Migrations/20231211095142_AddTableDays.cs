using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20231211095142)]
    public class AddDaysTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS Days;
               CREATE TABLE Days (
                    id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    name VARCHAR(255)
                );
                INSERT INTO Days VALUES (1, 'Monday'), (2, 'Tuesday'), (3, 'Wednesday'), (4, 'Thursday'), (5, 'Friday'), (6, 'Saturday'), (7, 'Sunday');";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS Days;";

            Execute.Sql(sql);
        }
    }
}
