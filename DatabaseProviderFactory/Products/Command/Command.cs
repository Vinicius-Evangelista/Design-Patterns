namespace AbstractFactory.Products.Command;

// Abstract Product A
public abstract class Command
{
    protected Command(string SqlCommand) => this.SqlCommand = SqlCommand;

    public virtual string SqlCommand { get; set; }

    public abstract void Execute();
}
