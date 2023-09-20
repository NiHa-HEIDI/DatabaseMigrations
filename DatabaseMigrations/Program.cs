using System.Configuration;
using System.Data;
using System.Reflection;
using FluentMigrator.Runner;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data.MySqlClient;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string dbType = "all";
            bool downMigrate = false;
            long? targetVersion = null;

            foreach (string arg in args)
            {
                string[] vals = arg.Split('=');
                if (vals[0] == "dbType")
                {
                    if (dbType == "all" || dbType == "core" || dbType == "city")
                    {
                        dbType = vals[1];
                    }
                    else
                    {
                        Console.Error.WriteLine($"Invalid db type '{dbType}'. Please input 'core', 'city' or 'all'.\nPress the enter key to exit..");
                        Environment.Exit(-1);
                    }
                }
                else if (vals[0] == "migrate")
                {
                    if (vals[1] == "down")
                    {
                        downMigrate = true;
                    }
                    else if (vals[1] == "up")
                    {
                        downMigrate = false;
                    }
                    else
                    {
                        Console.Error.WriteLine($"Invalid input '{vals[1]}' for migrate. Please input 'up' or 'down'.\nPress the enter key to exit..");
                        Environment.Exit(-1);
                    }
                }
                else if (vals[0] == "targetVersion")
                {
                    if (long.TryParse(vals[1], out long target))
                    {
                        targetVersion = target;
                    }
                    else
                    {
                        Console.Error.WriteLine($"Invalid input '{vals[1]}' for down targetVersion. Please input a valid integer version value.\nPress the enter key to exit..");
                        Environment.Exit(-1);
                    }
                }
                else
                {
                    Console.Error.WriteLine($"Invalid params '{vals[0]}' for down migrate. Please input 'dbType', 'migrate' or 'targetVersion'.\nPress the enter key to exit..");
                    Environment.Exit(-1);
                }
            }

            if (downMigrate)
            {
                if (!targetVersion.HasValue)
                {
                    Console.Error.WriteLine("TargetVersion is required while migrating down.");
                    Environment.Exit(-1);
                }
                if (dbType == "all")
                {
                    Console.Error.WriteLine("The parameter dbType cannot be 'all'. Please input 'core' or 'city'");
                    Environment.Exit(-1);
                }
            }

            string coreConnectionString = ConfigurationManager.ConnectionStrings["CoreDBConnection"].ConnectionString;
            if (dbType == "all" || dbType == "core")
            {
                using (var serviceProvider = CreateServices(coreConnectionString, true))
                using (var scope = serviceProvider.CreateScope())
                {
                    Console.WriteLine($"\n\n\n-------------------------------------------------------------------------------");
                    Console.WriteLine("Running migrations for Core DB ...");

                    Console.WriteLine($"-------------------------------------------------------------------------------");
                    UpdateDatabase(scope.ServiceProvider, downMigrate, targetVersion);
                }
            }

            if (dbType == "all" || dbType == "city")
            {
                var databaseConnections = new List<dynamic>();
                string connectionString = ConfigurationManager.ConnectionStrings["CityDBZeroConnection"].ConnectionString;
                databaseConnections.Add(new { cityId = 0, connectionString });
                DataTable dt = new DataTable();

                using (MySqlConnection conn = new MySqlConnection(coreConnectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();

                        cmd.CommandText = "SELECT Id, ConnectionString FROM cities";
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);

                        conn.Close();
                    }
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    databaseConnections.Add(new { cityId = dt.Rows[i]["Id"], connectionString = dt.Rows[i]["ConnectionString"] });
                }

                foreach (var connection in databaseConnections)
                {
                    string cityConnectionString = connection.connectionString.ToString();
                    using (var serviceProvider = CreateServices(cityConnectionString))
                    using (var scope = serviceProvider.CreateScope())
                    {
                        Console.WriteLine($"\n\n\n-------------------------------------------------------------------------------");
                        Console.WriteLine($"Running migrations for City DB {connection.cityId} ...");
                        Console.WriteLine($"-------------------------------------------------------------------------------");
                        UpdateDatabase(scope.ServiceProvider, downMigrate, targetVersion);
                    }
                }
            }
        }

        private static ServiceProvider CreateServices(string connectionString, bool isCoreDb = false)
        {
            string assemblyName = isCoreDb ? "CoreDBMigrations" : "CityDBMigrations";
            return new ServiceCollection()
                // Add common FluentMigrator services
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    // Add MySQL support to FluentMigrator
                    .AddMySql5()
                    // Set the connection string
                    .WithGlobalConnectionString(connectionString)
                    // Define the assembly containing the migrations
                    .ScanIn(Assembly.Load(assemblyName)).For.All())
                // Enable logging to console in the FluentMigrator way
                .AddLogging(lb => lb.AddFluentMigratorConsole())
                // Build the service provider
                .BuildServiceProvider(false);
        }

        private static void UpdateDatabase(IServiceProvider serviceProvider, bool downMigrate, long? targetVersion)
        {
            // Instantiate the runner
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();

            // Execute the migrations
            if (downMigrate && targetVersion.HasValue)
            {
                runner.MigrateDown(targetVersion.Value);
            }
            else if (targetVersion.HasValue)
            {
                runner.MigrateUp(targetVersion.Value);
            }
            else
            {
                runner.MigrateUp();
            }
        }
    }
}