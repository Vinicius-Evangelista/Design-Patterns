using AbstractFactory.Client;
using AbstractFactory.Enums;

namespace AbstractFactory;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Select a Database provider: ");
        
        PrintDatabases();

        if (int.TryParse(Console.ReadLine(), out int dbChoice) && Enum.IsDefined((DbType)dbChoice))
        {
            var db = CreateDatabaseFactory.CreateDatabase((DbType)dbChoice);

            db.CreateConnection().Connect();
            db.CreateCommand().Execute();
        }
        else
        {
            Console.WriteLine("Invalid choice. Please select a valid Database provider");
        }
    }

    static void PrintDatabases()
    {
        foreach (DbType dbType in Enum.GetValues(typeof(DbType)))
        {
            Console.WriteLine($"{(int)dbType} - {dbType}");
        }
    }
}