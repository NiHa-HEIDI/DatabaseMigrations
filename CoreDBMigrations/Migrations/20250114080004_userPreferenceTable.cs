using FluentMigrator;

namespace CoreDBMigrations.Migrations
{
    [Migration(20250114080004)]
    public class AddUserPreference : Migration
    {
        public override void Up()
        {
            string sql =
               @"CREATE TABLE user_preferences (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    userId INT NOT NULL,                      
                    createdAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP, 
                    updatedAt TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP, 
                    FOREIGN KEY (userId) REFERENCES users(id)
                );
                CREATE TABLE user_preference_cities (
                    id INT AUTO_INCREMENT PRIMARY KEY, 
                    preferenceId INT NOT NULL,                       
                    cityId INT NOT NULL,                             
                    FOREIGN KEY (preferenceId) REFERENCES user_preferences(id), 
                    FOREIGN KEY (cityId) REFERENCES cities(id)
                );
                CREATE TABLE user_preference_categories (
                    id INT AUTO_INCREMENT PRIMARY KEY, 
                    preferenceId INT NOT NULL,                       
                    categoryId INT NOT NULL,                             
                    FOREIGN KEY (preferenceId) REFERENCES user_preferences(id), 
                    FOREIGN KEY (categoryId) REFERENCES categories(id)
                );";

            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"DROP TABLE IF EXISTS user_preference_cities;
                DROP TABLE IF EXISTS user_preference_categories;
                DROP TABLE IF EXISTS user_preferences;";

            Execute.Sql(sql);
        }
    }
}
