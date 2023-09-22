using AbstractFactory.Products.Command;
using AbstractFactory.Products.Command.Postgres;
using AbstractFactory.Products.Connection;
using AbstractFactory.Products.Connection.PostgresConnection;

namespace AbstractFactory.Factories;

// Concrete Factory B
public class DatabasePostgres : DatabaseFactory
{
    public override Command CreateCommand()
    {
        return new PostgresCommand("Postgress Command");
    }

    public override Connection CreateConnection()
    {
        return new PostgresConnection("Postgres Connection");
    }
}

