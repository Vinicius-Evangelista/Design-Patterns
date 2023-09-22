namespace AbstractFactory.Products.Connection.SqlServerConnection;

// Concrete Product B
public class SqlServerConnection : Connection, ISqlServerConnection
{
    public SqlServerConnection(string ConnectionString) : base(ConnectionString)
    {
    }

    public override void Connect()
    {
        Console.WriteLine($"Connecting to SqlServer...");
        Console.WriteLine($"ConnectionString: {ConnectionString}");
    }

    public void SqlConnectionString()
    {
        throw new NotImplementedException();
    }
}
