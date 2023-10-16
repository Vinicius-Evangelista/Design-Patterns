using FileOperations;

var invoker = new FileOperationInvoker();

var fileList = new List<FileOperations.File>();


while (true)
{
    Console.WriteLine();
    PrintFiles(fileList);
    Console.WriteLine();

    PrintOptions();
   
    var option = Convert.ToInt32(Console.ReadLine());
    

    switch (option)
    {
        case 1:
            {
                Console.Write("File name: ");
                var fileName = Console.ReadLine() ?? "default";

                Console.Write("File extension: ");
                var extension = Console.ReadLine() ?? "txt";

                var file = new FileOperations.File(fileName, extension);

                invoker.Execute(new CreateFileCommand(file, ref fileList));
            }
            break;

        case 2:
            invoker.Undo();
            break;
        
        case 3:
            invoker.Redo(); 
            break;

        default:
            break;
    }
}

static void PrintFiles(List<FileOperations.File> files)
{
    foreach (var file in files)
    {
        Console.WriteLine(file.Name + file.Extension);
    }
}

static void PrintOptions()
{
    Console.WriteLine("1 - Create File");
    Console.WriteLine("2 - Desfazer última ação");
    Console.WriteLine("3 - Refazer última ação");
}
