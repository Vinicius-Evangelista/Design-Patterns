namespace AbstractFactory.Products.Command.Postgres;

// Concrete Product A 
public class PostgresCommand : Command, IPostgresCommand
{
    public PostgresCommand(string SqlCommand) : base(SqlCommand)
    {
    }

    public override void Execute()
    {
        Console.WriteLine($"Executing Postgres Command: {SqlCommand}");
    }
}
