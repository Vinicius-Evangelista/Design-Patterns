namespace FileServiceStorage.Facade;

public interface IFileStorageService
{
    public Task UploadAsync();
    public Task DownloadAsync();
    public Task DeleteAsync();
    public Task UpdateAsync();
}