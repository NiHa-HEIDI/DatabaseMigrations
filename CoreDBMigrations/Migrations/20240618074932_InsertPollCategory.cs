using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240618074932)]
    public class InsertPollCategory : Migration
    {
        public override void Up()
        {
            string sql =
               @"INSERT INTO categories (id, name, category_order) values (25, 'Polls', 25);
               ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql = 
                @"DELETE FROM categories WHERE id = 25;
                ";
            Execute.Sql(sql);
        }
    }
}