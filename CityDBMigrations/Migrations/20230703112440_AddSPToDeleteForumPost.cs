using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230810131716)]
    public class AddSPToDeleteForumPost : Migration
    {
        public override void Up()
        {
            /* 
                24 July 2023 -> Deleted child comments before deleting parent comments - Moiz
                2 August 2023 -> Delete reported post - Sonu
                10 August 2023 -> rename ReportedPostes to ReportedPosts - Ajay
            */
            string sql =
               @"
                DROP PROCEDURE IF EXISTS sp_DeleteForumPost;
                CREATE PROCEDURE sp_DeleteForumPost (IN forumId int, IN postId int) 
                BEGIN
                    DECLARE EXIT HANDLER FOR SQLEXCEPTION 
                        BEGIN
                            ROLLBACK;
                            RESIGNAL;
                        END;
                    START TRANSACTION;
                        DELETE FROM forumcomments fc where fc.forumId = forumId and fc.postId = postId and fc.parentId is not NULL;
                        DELETE FROM forumcomments fc where fc.forumId = forumId and fc.postId = postId;
                        DELETE FROM reportedposts rp where rp.forumid = forumId and rp.postId = postId;
		                DELETE FROM forumposts fp where fp.forumId = forumId and fp.id = postId;
	                COMMIT;
                END;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
                @"DROP PROCEDURE IF EXISTS sp_DeleteForumPost;";

            Execute.Sql(sql);
        }
    }
}