using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240119134153)]
    public class AddPayments: Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS payments;
                CREATE TABLE payments (
	                id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    paymentId varchar(255),
                    paymentProviderType varchar(255),
                    status int,
                    amount double,
                    FOREIGN KEY (status) REFERENCES paymentstatus(id) ON DELETE CASCADE
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS payments;";

            Execute.Sql(sql);
        }
    }
}
