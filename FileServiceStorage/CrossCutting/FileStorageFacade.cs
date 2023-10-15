namespace FileServiceStorage.Facade;

public class FileStorageFacade : IFileStorageFacade
{
    private readonly IFileStorageService FileStorage;

    public FileStorageFacade(IFileStorageService fileStorage)
    {
        FileStorage = fileStorage;
    }

    public Task DeleteAsync(Guid FileId) => 
        FileStorage.DeleteAsync();

    public Task DownloadAsync(string FilePath) => 
        FileStorage.DownloadAsync();

    public Task UpdateAsync(Guid FileId, Stream fileStream) => 
        FileStorage.UpdateAsync();

    public Task UploadAsync(Stream fileStream, string FileName) => 
        FileStorage.UploadAsync();    
}
