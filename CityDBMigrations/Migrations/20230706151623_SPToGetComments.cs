using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230731105813)]
    public class SPToGetComments : Migration
    {
        public override void Up()
        {
            /*
                Changes made
                --------------------------------------------------------------------------
                26 July 2023 -> changed ChildCount to childCount AND sorted desc - Moiz
                31 July 2023 -> Fetch user details and child comments - Ajay
            */
            string sql =
               @"
                DROP PROCEDURE IF EXISTS sp_GetComments;
                CREATE PROCEDURE sp_GetComments (IN forumId int, IN postId int, IN parentId int, IN pageNo int, IN pageSize int)
                BEGIN
                    DECLARE EXIT HANDLER FOR SQLEXCEPTION 
                        BEGIN
                            ROLLBACK;
                            RESIGNAL;
                        END;
                    START TRANSACTION;
					IF parentId IS NULL THEN
                        SELECT  c.id, c.forumId, c.postId, c.comment, c.createdAt, count(*) - 1 as childrenCount, u.id as cityUserId, u.username, u.firstname, u.lastname, u.image FROM (
                        SELECT * FROM forumcomments fc WHERE fc.postId = postId AND fc.forumId = forumId AND fc.parentId is NULL
                        UNION ALL
                        SELECT fc1.* FROM forumcomments fc1 
                        INNER JOIN 
                        forumcomments fc2 ON fc1.id = fc2.parentId
                        WHERE fc1.postId = postId AND fc1.forumId = forumId) AS c 
                        INNER JOIN
                        users u ON u.id = c.userId WHERE postId = postId AND forumId = forumId AND parentId is NULL GROUP BY c.id, c.forumId, c.postId, c.comment, c.createdAt, u.id, u.username, u.firstname, u.lastname, u.image ORDER BY c.createdAt DESC LIMIT pageNo, pageSize; 
					ELSE
						SELECT fc.id, fc.forumId, fc.postId, fc.comment, fc.createdAt, fc.parentId, u.id as cityUserId, u.username, u.firstname, u.lastname, u.image FROM forumcomments fc
                        INNER JOIN
                        users u ON u.id = fc.userId 
                        WHERE fc.postId = postId AND fc.forumId = forumId AND fc.parentId = parentId
                        ORDER BY fc.createdAt DESC  LIMIT pageNo, pageSize;
                    END IF;
	                COMMIT;
                END;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
                @"DROP PROCEDURE IF EXISTS sp_GetComments;";

            Execute.Sql(sql);
        }
    }
}