using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230703112440)]
    public class AddSPToDeleteForumPost : Migration
    {
        public override void Up()
        {
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
                        DELETE FROM forumcomments fc where fc.forumId = forumId and fc.postId = postId;
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