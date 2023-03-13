using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230313065819)]
    public class AddImageColumnCitiesTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE listings ADD subcategoryId INT;
                ALTER TABLE listings ADD CONSTRAINT fk_subcategoryId FOREIGN KEY (subcategoryId) REFERENCES subcategory(Id);";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE listings DROP FOREIGN KEY  fk_subcategoryId;
                ALTER TABLE listings DROP column subcategoryId;";

            Execute.Sql(sql);
        }
    }
}
