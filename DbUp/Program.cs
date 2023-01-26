using System;
using DbUp;

namespace DbUpConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Data Source=HSA_Coleta.db;";
            var upgrader =
                DeployChanges.To
                .SQLiteDatabase(connectionString)
                .WithScriptsFromFileSystem(@".\Migrations")
                .LogToConsole()
                .Build();
            var result = upgrader.PerformUpgrade();
            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(result.Error);
                Console.ResetColor();
                Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success!");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
