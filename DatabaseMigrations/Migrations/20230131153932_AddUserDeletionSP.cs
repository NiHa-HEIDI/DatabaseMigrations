using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230131153932)]
    public class AddUserDeletionSP : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP PROCEDURE IF EXISTS sp_DeleteAllUserData;
            CREATE PROCEDURE sp_DeleteAllUserData(IN userIdToDelete int)
                BEGIN  
	                DECLARE exit handler FOR SQLEXCEPTION, SQLWARNING
                    BEGIN
		                ROLLBACK;
		                RESIGNAL;
                    END;

	                START TRANSACTION;
		                DELETE FROM LISTINGS where userId = userIdToDelete;
		                DELETE FROM USERS where Id = userIdToDelete;
	                COMMIT;
  
                END;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP PROCEDURE IF EXISTS sp_DeleteAllUserData;";

            Execute.Sql(sql);
        }
    }
}
