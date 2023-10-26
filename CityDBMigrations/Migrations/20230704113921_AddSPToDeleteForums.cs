using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20231025162727)]
    public class AddSPToDeleteForums : Migration
    {
        public override void Up()
        {   
            /*
                Changes made
                --------------------------------------------------------------------------
                2 August 2023 -> changed postReports to RepostedPosts - Sonu
                25 Oct 2023 -> changed commentes to delete not null parents - Ajay
            */
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
                        DELETE FROM forumcomments fc where fc.forumId = forumId and fc.parentId is not NULL;
                        DELETE FROM forumcomments fc where fc.forumId = forumId;
                        DELETE FROM reportedposts pr where pr.forumId = forumId;
                        DELETE FROM forumposts fp where fp.forumId = forumId;
                        DELETE FROM forumrequests fr where fr.forumId = forumId;
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