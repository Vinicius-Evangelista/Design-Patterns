using AbstractFactory.Products.Command;
using AbstractFactory.Products.Command.SqlServer;
using AbstractFactory.Products.Connection;
using AbstractFactory.Products.Connection.SqlServerConnection;

namespace AbstractFactory.Factories;

// Concrete Factory A
public class DatabaseSqlServer : DatabaseFactory
{
    public override SqlServerCommand CreateCommand()
    {
        return new SqlServerCommand("SqlServer Command");
    }

    public override SqlServerConnection CreateConnection()
    {
        return new SqlServerConnection("SqlServer Connection");
    }
}

