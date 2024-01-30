using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240119134140)]
    public class AddPaymentStatusTable: Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS paymentstatus;
                CREATE TABLE paymentstatus (
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    name varchar(255)
                );
                insert into paymentstatus values (1,""Pending""), (2,""Paid""), (3,""Failed""), (4,""Cancelled""), (5,""Refund Pending""), (6,""Refunded"");";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS paymentstatus;";

            Execute.Sql(sql);
        }
    }
}
