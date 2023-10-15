namespace FileServiceStorage.CrossCutting;

public class AmazonS3 : IAmazonS3
{
    public string DeleteAsync() => "File Deleted.";

    public string DownloadAsync() => "File Downloaded.";

    public string UpdateAsync() => "File Updated.";

    public string UploadAsync() => "File Uploaded.";
}
