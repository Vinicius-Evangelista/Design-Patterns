namespace FileServiceStorage.Facade;

public interface IFileStorageFacade
{
    public Task UploadAsync(Stream fileStream, string FileName);
    public Task DownloadAsync(string FilePath);
    public Task DeleteAsync(Guid FileId);
    public Task UpdateAsync(Guid FileId, Stream fileStream);
}