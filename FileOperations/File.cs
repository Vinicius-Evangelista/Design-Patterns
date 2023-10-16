namespace FileOperations;

public class File
{
    public string Name { get; set; }

    public string Extension { get; set; }

    public File(string name, string extension)
    {
        Name = name;
        Extension = extension;
    }
}
