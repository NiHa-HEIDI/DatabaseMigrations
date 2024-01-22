using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240122123001)]
    public class AddSpToDeleteCityUser : Migration
    {
        public override void Up()
        {
            string sql =
               @"
                DROP PROCEDURE IF EXISTS sp_DeleteCityUser;
                CREATE PROCEDURE sp_DeleteCityUser (IN userId int) 
                BEGIN
                    DECLARE EXIT HANDLER FOR SQLEXCEPTION 
                        BEGIN
                            ROLLBACK;
                            RESIGNAL;
                        END;
                    START TRANSACTION;
                        SET SQL_SAFE_UPDATES = 0;
		                DELETE FROM forumcomments fc WHERE fc.userId = userId and fc.parentId is not NULL;
                        DELETE fc1 FROM forumcomments fc1
                            INNER JOIN forumcomments fc2 ON fc1.parentId = fc2.id
                            WHERE fc2.userId = userId;
                        DELETE fc1 FROM forumcomments fc1
                            INNER JOIN forumposts fc2 ON fc1.postId = fc2.id
                            WHERE fc2.userId = userId and fc1.parentId IS NOT NULL;
                        DELETE fc1 FROM forumcomments fc1
                            INNER JOIN forumposts fc2 ON fc1.postId = fc2.id
                            WHERE fc2.userId = userId;
                        DELETE FROM forumcomments fc WHERE fc.userId = userId;
                        DELETE FROM reportedposts rp WHERE rp.userId = userId;
                        DELETE rp FROM reportedposts rp
                            INNER JOIN forumposts fp ON rp.postId = fp.id
                            WHERE fp.userId = userId;
		                DELETE FROM forumposts fp WHERE fp.userId = userId;
		                DELETE FROM forummembers fm WHERE fm.userId = userId;
                        DELETE FROM forumrequests fr WHERE fr.userId = userId;
                        DELETE li FROM listing_images li
                            INNER JOIN listings l ON l.id = li.listingId
                            WHERE l.userId = userId;
                        DELETE FROM listings l WHERE l.userId = userId;
                        SET SQL_SAFE_UPDATES = 1;
                    COMMIT;
                END;";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
                @"DROP PROCEDURE IF EXISTS sp_DeleteCityUser;";

            Execute.Sql(sql);
        }
    }
}
