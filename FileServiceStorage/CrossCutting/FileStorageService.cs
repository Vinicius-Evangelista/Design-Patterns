using FileServiceStorage.CrossCutting;
using FileServiceStorage.Facade;

namespace OnlineShopping.CrossCutting;

public class FileStorageService : IFileStorageService
{
    private readonly IAmazonS3 s3Client;

    public FileStorageService(IAmazonS3 s3Client) =>
        this.s3Client = s3Client;

    public async Task DeleteAsync() => 
        await Task.Run(() => s3Client.UpdateAsync());

    public async Task DownloadAsync() => 
        await Task.Run(() => s3Client.DownloadAsync());

    public async Task UpdateAsync() => 
        await Task.Run(() => s3Client.UpdateAsync());

    public async Task UploadAsync() => 
        await Task.Run(() => s3Client.UploadAsync());
}
