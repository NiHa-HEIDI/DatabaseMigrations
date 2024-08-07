using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20240807113139)]
    public class AddAccountToCardTransactions : Migration
    {
        public override void Up()
        {
            string sql =
               @"ALTER TABLE store_card_transaction ADD accountId int,
               ADD CONSTRAINT FK_Store_Transaction_Account FOREIGN KEY (accountId) REFERENCES card_account(id);";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"ALTER TABLE store_card_transaction DROP CONSTRAINT FK_Store_Transaction_Account;
                 ALTER TABLE store_card_transaction DROP COLUMN accountId;";

            Execute.Sql(sql);
        }
    }
}
