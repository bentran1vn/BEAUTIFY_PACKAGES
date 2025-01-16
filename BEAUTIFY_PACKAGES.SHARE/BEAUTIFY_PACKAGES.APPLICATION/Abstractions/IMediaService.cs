using Microsoft.AspNetCore.Http;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.APPLICATION.Abstractions;

public interface IMediaService
{
    Task<string> UploadImageAsync(IFormFile file);
}