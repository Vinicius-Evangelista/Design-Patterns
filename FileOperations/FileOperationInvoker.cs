namespace FileOperations;

public class FileOperationInvoker
{
    private readonly List<FileOperationCommander> _commands = new();
    private int actualCommandIndex = -1;

    public FileOperationInvoker()
    {
    }

    public void Execute(FileOperationCommander command)
    {
        actualCommandIndex++;
        _commands.Add(command);
        command.Execute();

    }

    public void Undo()
    {
        _commands[actualCommandIndex].Undo();
        actualCommandIndex--;
    }
        

    public void Redo() =>
        _commands[actualCommandIndex].Redo();
}
