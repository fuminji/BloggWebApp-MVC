namespace Bloggie.Web.Repositories
{
    public interface IImageRepositroy
    {
        Task<string> UploadAsync(IFormFile file);
    }
}
