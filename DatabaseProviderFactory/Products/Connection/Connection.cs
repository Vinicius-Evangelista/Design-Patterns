namespace AbstractFactory.Products.Connection;

// Abstract Product B
public abstract class Connection : IConnection
{
    protected Connection(string ConnectionString) => this.ConnectionString = ConnectionString;

    public virtual string ConnectionString { get; set; }

    public abstract void Connect();
}
