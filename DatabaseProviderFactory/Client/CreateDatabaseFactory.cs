using AbstractFactory.Factories;
using AbstractFactory.Enums;

namespace AbstractFactory.Client;

// This is a Factory Method (Client) that Create a Database.
public abstract class CreateDatabaseFactory
{

    public CreateDatabaseFactory(DbType dbType)
    {
        CreateDatabase(dbType);
    }

    public static DatabaseFactory CreateDatabase(DbType dbType)
    {
        switch (dbType)
        {
            case DbType.SqlServer:
                return new DatabaseSqlServer();
            case DbType.Postgres:
                return new DatabasePostgres();
            default:
                throw new ArgumentException("Invalid Database type.");
        }
    }
}
