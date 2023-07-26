using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230726163023)]
    public class SPToGetComments : Migration
    {
        public override void Up()
        {
            /*
                26 July 2023 -> chnaged ChildCount to childCount AND sorted desc -Moiz
            */
            string sql =
               @"
                DROP PROCEDURE IF EXISTS sp_GetComments;
                CREATE PROCEDURE sp_GetComments (IN forumId int, IN postId int, IN pageNo int, IN pageSize int) 
                BEGIN
                    DECLARE EXIT HANDLER FOR SQLEXCEPTION 
                        BEGIN
                            ROLLBACK;
                            RESIGNAL;
                        END;
                    START TRANSACTION;
                        SELECT  id, forumId, postId, comments, createdAt, userId, count(*) - 1 as childrenCount FROM (
                        SELECT * FROM forumcomments fc WHERE fc.postId = postId AND fc.forumId = forumId AND fc.parentId is NULL
                        UNION ALL
                        SELECT fc1.* FROM forumcomments fc1 
                        INNER JOIN 
                        forumcomments fc2 ON fc1.id = fc2.parentId
                        WHERE fc1.postId = postId AND fc1.forumId = forumId) AS t WHERE postId = postId AND forumId = forumId AND parentId is NULL GROUP BY id, forumId, postId, comments, createdAt, userId  ORDER BY createdAt DESC  LIMIT pageNo ,pageSize; 

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