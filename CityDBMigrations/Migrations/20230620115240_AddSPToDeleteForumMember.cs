using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230620115240)]
    public class AddSPToDeleteForumMember : Migration
    {
        public override void Up()
        {
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
		                DELETE FROM postreports pr where pr.forumId = forumId and pr.userId = userId;
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