namespace JobFinder.Service.StorageService
{
    public interface IStorageService
    {
        Task<string> UploadFile(IFormFile file, string container, string name);
    }
}
