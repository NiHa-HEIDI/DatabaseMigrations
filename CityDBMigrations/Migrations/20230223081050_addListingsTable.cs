using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230223081050)]
    public class AddListingsTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS listings;
                create table listings(
                    id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    userId int, 
                    FOREIGN KEY(userId) REFERENCES USERS(id),
                    title varchar(255),
                    place varchar(255),
                    description varchar(255),
                    socialMedia varchar(255),
                    media varchar(255),
                    categoryId int,
                    FOREIGN KEY(categoryId) REFERENCES CATEGORIES(id),
                    address varchar(255),
                    email varchar(255),
                    phone varchar(255),
                    website varchar(255),
                    price DOUBLE,
                    discountPrice DOUBLE,
                    logo varchar(255),
                    statusId int,
                    FOREIGN KEY(statusId) REFERENCES status(id),
                    sourceId int,
                    FOREIGN KEY(sourceId) REFERENCES source(id),
                    longitude double,
                    latitude double,
                    villageId int,
                    FOREIGN KEY(villageId) REFERENCES village(id),
                    startDate DATETIME,
                    endDate DATETIME
                );";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS listings;";

            Execute.Sql(sql);
        }
    }
}
