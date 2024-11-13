using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20241112101626)]
    public class AddListingsTable : Migration
    {
        public override void Up()
        {
            string sql =
               @"DROP TABLE IF EXISTS listings;
                CREATE TABLE listings (
                    id INT NOT NULL AUTO_INCREMENT,
                    oldId INT,
                    address VARCHAR(255),
                    appointmentId INT,
                    FOREIGN KEY(appointmentId) REFERENCES appointments(id),
                    categoryId INT,
                    FOREIGN KEY(categoryId) REFERENCES categories(id),
                    cityId INT NOT NULL,
                    FOREIGN KEY(cityId) REFERENCES cities(id),
                    createdAt DATETIME ,
                    description TEXT,
                    discountPrice DOUBLE,
                    email VARCHAR(255),
                    endDate DATETIME,
                    expiryDate DATETIME,
                    externalId TEXT,
                    latitude DOUBLE,
                    longitude DOUBLE,
                    pdf VARCHAR(255),
                    phone VARCHAR(255),
                    place VARCHAR(255),
                    price DOUBLE,
                    showExternal TINYINT(1) DEFAULT 0,
                    sourceId INT,
                    FOREIGN KEY(sourceId) REFERENCES source(id),
                    startDate DATETIME,
                    statusId INT,
                    subcategoryId INT,
                    FOREIGN KEY(subcategoryId) REFERENCES subcategory(Id),
                    title VARCHAR(255),
                    updatedAt DATETIME,
                    userId INT,
                    FOREIGN KEY(userId) REFERENCES users(id),
                    viewCount INT DEFAULT 0 NOT NULL,
                    villageId INT,
                    FOREIGN KEY(villageId) REFERENCES village(id),
                    website TEXT,
                    zipcode INT,
                    PRIMARY KEY (id)
                );
";
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
