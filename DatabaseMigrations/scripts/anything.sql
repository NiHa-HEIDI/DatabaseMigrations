DROP PROCEDURE IF EXISTS dfdf;
            CREATE PROCEDURE dfdf(IN userIdToDelete int)
                BEGIN
                    DECLARE exit handler FOR SQLEXCEPTION, SQLWARNING
                    BEGIN
                        ROLLBACK;
                        RESIGNAL;
                    END;

                    START TRANSACTION;
                        DELETE FROM LISTINGS where userId = userIdToDelete;
                        DELETE FROM USERS where Id = userIdToDelete;
                    COMMIT;

                END;;