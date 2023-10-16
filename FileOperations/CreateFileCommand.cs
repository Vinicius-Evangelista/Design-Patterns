namespace FileOperations;

public class CreateFileCommand : FileOperationCommander
{
    public CreateFileCommand(File file, ref List<File> files) : base(file, ref files)
    {
    }

    public override void Execute()
    {
        Files.Add(File);
        Console.WriteLine($"File {File.Name} created!");
    }


    public override void Redo() =>
        Execute();


    public override void Undo()
    {
        Files.Remove(File);
        Console.WriteLine($"File {File.Name} deleted!");
    }
}
