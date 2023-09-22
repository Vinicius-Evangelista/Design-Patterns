namespace AbstractFactory.Products.Connection.PostgresConnection;

// Concrete Product B
public class PostgresConnection : Connection, IPostgresConnection 
{
    public PostgresConnection(string ConnectionString) : base(ConnectionString)
    {
    }

    public override void Connect()
    {
        Console.WriteLine($"ConnectionString: {ConnectionString}");
        Console.WriteLine($"Connecting to Postgres...");
    }

    public void CreatePostgresCommand()
    {
        throw new NotImplementedException();
    }
}
