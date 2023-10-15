using FileServiceStorage.CrossCutting;

namespace FileServiceStorage;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Upload an File");
        var fileStorgeFacade = new FileStorageFacade(new FileStorageService(new AmazonS3()));

        Stream stream = new MemoryStream();
        string fileName = "Just Example";
        Guid fileId = Guid.NewGuid(); 

        fileStorgeFacade.UploadAsync(stream, fileName);
        fileStorgeFacade.DeleteAsync(fileId);
        fileStorgeFacade.UpdateAsync(fileId, stream);
        fileStorgeFacade.DownloadAsync(fileName);
    }
}