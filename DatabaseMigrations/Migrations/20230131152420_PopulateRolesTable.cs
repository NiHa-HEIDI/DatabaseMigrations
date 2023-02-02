using FluentMigrator;
using Mysqlx.Crud;
using System.Data;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230131152420)]
    public class PopulateRolesTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"
                insert into ROLES values (1, ""Administrator"");
                insert into ROLES values (2, ""Department Head"");
                insert into ROLES values (3, ""Content Creator"");";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DELETE FROM ROLES WHERE id in (1, 2, 3);";
            Execute.Sql(sql);
        }
    }
}
