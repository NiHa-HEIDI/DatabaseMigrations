using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230926103443)]
    public class AddSocialMediaSubCatagory : Migration
    {
        public override void Up()
        {
            string sql =
               @"INSERT INTO subcategory(id, name, categoryId) values (11,""Social Media"", 1);
               ALTER TABLE listings RENAME COLUMN media TO externalId;
               INSERT INTO source(id, name, categoryId) values (2,""Instagram"");
               ";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql = @"DELETE FROM subcategory WHERE id = 11;
                            DELETE FROM source WHERE id = 2;
                            ALTER TABLE listings RENAME COLUMN externalId TO media;";
            Execute.Sql(sql);
        }
    }
}
