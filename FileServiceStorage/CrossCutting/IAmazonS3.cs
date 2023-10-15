namespace FileServiceStorage.CrossCutting;

public interface IAmazonS3
{
    public string UploadAsync();
    public string DownloadAsync();
    public string DeleteAsync();
    public string UpdateAsync();
}