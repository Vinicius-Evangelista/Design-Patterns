using System.Runtime.CompilerServices;

namespace FileOperations;

public abstract class FileOperationCommander
{
    public File File { get; private set; }

    public List<File> Files { get; set; }

    public FileOperationCommander(File file, ref List<File> files)
    {
        File = file;
        Files = files;
    }

    public abstract void Execute();

    public abstract void Undo();

    public abstract void Redo();
}
