using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20230131182243)]
    public class AddListingsTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"create table LISTINGS(
                    id int NOT NULL PRIMARY KEY AUTO_INCREMENT,
                    userId int, 
                    FOREIGN KEY(userId) REFERENCES users(id),
                    title varchar(255),
                    place varchar(255),
                    description varchar(255),
                    socialMedia varchar(255),
                    media varchar(255),
                    categoryId int,
                    FOREIGN KEY(categoryId) REFERENCES categories(id),
                    subCategoryId int,
                    FOREIGN KEY(subCategoryId) REFERENCES subcategories(id),
                    address varchar(255),
                    email varchar(255),
                    phone varchar(255),
                    website varchar(255),
                    price DOUBLE,
                    discountPrice DOUBLE,
                    logo varchar(255),
                    statusId int,
                    FOREIGN KEY(statusId) REFERENCES statuses(id),
                    sourceId int,
                    FOREIGN KEY(sourceId) REFERENCES sources(id),
                    longitude double,
                    lattitude double,
                    cityId int,
                    FOREIGN KEY(cityId) REFERENCES cities(id),
                    startDate DATETIME,
                    endDate DATETIME
                    );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS LISTINGS;";

            Execute.Sql(sql);
        }
    }
}
