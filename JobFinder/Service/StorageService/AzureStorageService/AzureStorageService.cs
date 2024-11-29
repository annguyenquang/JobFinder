using Azure.Storage.Blobs;
using JobFinder.Model.Utils;
using JobFinder.Model.Utils.Constants;
using Microsoft.Extensions.Options;

namespace JobFinder.Service.StorageService;

public class AzureStorageService : IStorageService
{
    private readonly BlobServiceClient? _blobServiceClient;

    public AzureStorageService(IOptions<AppSettings> _appSettings)
    {
        var connectionStr = _appSettings.Value.AZURE_STORAGE_CONNECTION_STRING;
        if (string.IsNullOrEmpty(connectionStr))
        {
            return;
            throw new Exception("Azure storage connection string is null or empty");
        }
        _blobServiceClient = new BlobServiceClient(connectionStr);
    }

    // public async Task<string> UploadFile(IFormFile file)
    // {
    //     if (_blobServiceClient == null)
    //     {
    //         throw new Exception("BlobServiceClient is null");
    //     }
    //
    //     var container = ChoseContainerByFileName(file.FileName);
    //     var containerClient = _blobServiceClient.GetBlobContainerClient(container);
    //     var blobClient = containerClient.GetBlobClient(file.FileName);
    //     await blobClient.UploadAsync(file.OpenReadStream(), true);
    //     return blobClient.Uri.AbsoluteUri;
    // }

    private static string ChoseContainerByFileName(string fileName)
    {
        var extension = Path.GetExtension(fileName);
        if (FileExtension.ImageExtensions.Contains(extension))
        {
            return fileName.StartsWith(AzureContainer.LogosContainer)
                ? AzureContainer.LogosContainer
                : AzureContainer.ImagesContainer;
        }

        if (FileExtension.PdfExtension.Equals(extension))
            return AzureContainer.DocumentsContainer;
        throw new Exception("Invalid file type");
    }

    public async Task<string> UploadFile(IFormFile file, string container, string fileName)
    {
        if (_blobServiceClient == null)
        {
            throw new Exception("BlobServiceClient is null");
        }

        var containerClient = _blobServiceClient.GetBlobContainerClient(container);
        var blobClient = containerClient.GetBlobClient(fileName + Path.GetExtension(file.FileName));
        await blobClient.UploadAsync(file.OpenReadStream(), true);
        return blobClient.Uri.AbsoluteUri;
    }
}