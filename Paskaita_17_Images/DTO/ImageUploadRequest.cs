using Microsoft.AspNetCore.Http;
using Paskaita_17_Images.Attributes;

namespace Paskaita_17_Images.DTO
{
    public class ImageUploadRequest
    {
        [MaxFileSize(5 * 1024 * 1024)]
        [AllowedExtensions(new string[] { ".png", ".jpg", ".jpeg" })]
        public IFormFile Image { get; set; }
    }
}
