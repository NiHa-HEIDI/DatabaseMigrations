using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230904144232)]
    public class AddDeleteServiceToServiceTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"INSERT INTO Services(id, name, isRunning, safeStop) values (1,""Delete expired listings"", 0, 0);
               ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
        }
    }
}