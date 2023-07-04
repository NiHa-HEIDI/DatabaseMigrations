using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230704113921)]
    public class AddSPToDeleteForums : Migration
    {
        public override void Up()
        {
            string sql =
               @"
                DROP PROCEDURE IF EXISTS sp_DeleteForums;
                CREATE PROCEDURE sp_DeleteForums (IN forumId int) 
                BEGIN
                    DECLARE EXIT HANDLER FOR SQLEXCEPTION 
                        BEGIN
                            ROLLBACK;
                            RESIGNAL;
                        END;
                    START TRANSACTION;
                        DELETE FROM forumcomments fc where fc.forumId = forumId;
                        DELETE FROM postreports pr where pr.forumId = forumId;
                        DELETE FROM forumposts fp where fp.forumId = forumId;
                        DELETE FROM ForumRequests fr where fr.forumId = forumId;
                        DELETE FROM forummembers fm where fm.forumId = forumId;
                        DELETE FROM forums fs where fs.id = forumId;
                    COMMIT;
                END;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
                @"DROP PROCEDURE IF EXISTS sp_DeleteForums;";

            Execute.Sql(sql);
        }
    }
}