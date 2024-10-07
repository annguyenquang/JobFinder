using Azure.Storage.Blobs;
using JobFinder.Model.Utils;
using Microsoft.Extensions.Options;

namespace JobFinder.Service.StorageService
{
    public class AzureStorageService : IStorageService
    {
        private readonly BlobServiceClient? _blobServiceClient;
        public AzureStorageService(IOptions<AppSettings> _appSettings)
        {
            var connnectionStr = _appSettings.Value.AZURE_STORAGE_CONNECTION_STRING;
            if (string.IsNullOrEmpty(connnectionStr))
            {
                throw new Exception("Azure storage connection string is null or empty");
            }
            _blobServiceClient = new BlobServiceClient(connnectionStr);
        }
        public async Task<string> UploadFile(IFormFile file)
        {
            if (_blobServiceClient == null)
            {
                throw new Exception("BlobServiceClient is null");
            }
            string client = Path.GetExtension(file.FileName.ToLower()) switch
            {
                ".jpg" => "images",
                ".jpeg" => "images",
                ".png" => "images",
                ".pdf" => "documents",
                _ => throw new Exception("Invalid file type")
            };
            BlobContainerClient containerClient = _blobServiceClient.GetBlobContainerClient(client);
            BlobClient blobClient = containerClient.GetBlobClient(file.FileName);
            await blobClient.UploadAsync(file.OpenReadStream(), true);
            return blobClient.Uri.AbsoluteUri;
        }
    }
}
