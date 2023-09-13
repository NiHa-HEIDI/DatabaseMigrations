using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230810131648)]
    public class AddSPToDeleteForumMember : Migration
    {
        public override void Up()
        {
            /*
                Changes made
                --------------------------------------------------------------------------
                2 August 2023 -> changed postReports to RepostedPosts - Sonu
                10 August 2023 ->Added logic to remove reports made on the user - Ajay
                13 Sept 2023 -> Changed ReportedPosts to reportedposts - Moiz
            */
            string sql =
               @"
                DROP PROCEDURE IF EXISTS sp_DeleteForumMember;
                CREATE PROCEDURE sp_DeleteForumMember (IN forumId int, IN userId int) 
                BEGIN
                    DECLARE EXIT HANDLER FOR SQLEXCEPTION  
                        BEGIN
                            ROLLBACK;
                            RESIGNAL;
                        END;
                    START TRANSACTION;
		                DELETE FROM forumcomments fc where fc.forumId = forumId and fc.userId = userId;
		                DELETE FROM reportedposts rp where rp.forumId = forumId and rp.userId = userId;
                        DELETE rp FROM reportedposts rp
                        INNER JOIN forumposts fp ON rp.postId = fp.id
                        WHERE fp.userId = userId;
		                DELETE FROM forumposts fp where fp.forumId = forumId and fp.userId = userId;
		                DELETE FROM forummembers fm where fm.forumId = forumId and fm.userId = userId;
	                COMMIT;
                END;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
                @"DROP PROCEDURE IF EXISTS sp_DeleteForumMember;";

            Execute.Sql(sql);
        }
    }
}