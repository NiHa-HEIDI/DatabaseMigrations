using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240213150152)]
    public class UpdateUserData : Migration
    {
        public override void Up()
        {
            string sql =
               @"SET SQL_SAFE_UPDATES = 0;
                UPDATE users u
                INNER JOIN heidi_core.users c ON u.username = c.username
                SET 
                    u.firstname = c.firstname,
                    u.lastname = c.lastname,
                    u.email = c.email,
                    u.phoneNumber = c.phoneNumber,
                    u.image = c.image,
                    u.description = c.description,
                    u.website = c.website,
                    u.roleId = c.roleId
                WHERE u.id IS NOT NULL;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
        }
    }
}
