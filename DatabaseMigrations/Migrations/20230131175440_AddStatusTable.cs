using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230131175440)]
    public class AddStatusTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"CREATE TABLE IF NOT EXISTS statuses(
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
	                status varchar(255)
                );
                insert into statuses (status) values ('active');
                insert into statuses (status) values ('inactive');
                insert into statuses (status) values ('pending');";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS statuses;";

            Execute.Sql(sql);
        }
    }
}
