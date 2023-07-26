using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230706151623)]
    public class SPToGetComments : Migration
    {
        public override void Up()
        {
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
                        SELECT  id, forumId, postId, comments, createdAt, userId, count(*) - 1 as ChildrenCount FROM (
                        SELECT * FROM heidi_city_1.forumcomments fc WHERE fc.postId = postId AND fc.forumId = forumId AND fc.parentId is NULL
                        UNION ALL
                        SELECT fc1.* FROM heidi_city_1.forumcomments fc1 
                        INNER JOIN 
                        heidi_city_1.forumcomments fc2 ON fc1.id = fc2.parentId
                        WHERE fc1.postId = postId AND fc1.forumId = forumId) AS t WHERE postId = postId AND forumId = forumId AND parentId is NULL GROUP BY id, forumId, postId, comments, createdAt, userId  LIMIT pageNo ,pageSize; 

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