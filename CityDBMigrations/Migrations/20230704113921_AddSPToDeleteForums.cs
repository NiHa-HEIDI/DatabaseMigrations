using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230802102756)]
    public class AddSPToDeleteForums : Migration
    {
        public override void Up()
        {   
            /*
                Changes made
                --------------------------------------------------------------------------
                2 August 2023 -> changed postReports to RepostedPosts - Sonu
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