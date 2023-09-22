namespace AbstractFactory.Products.Command.SqlServer;

// Concrete Product A
public class SqlServerCommand : Command, ISqlServerCommand
{
    public SqlServerCommand(string SqlCommand) : base(SqlCommand)
    {
    }

    public override void Execute()
    {
        Console.WriteLine($"Executing SqlServer Command: {SqlCommand}");
    }
}
