using Microsoft.AspNetCore.Mvc;
using Paskaita_17_Images.DTO;
using System.IO;

namespace Paskaita_17_Images.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        [HttpPost]
        public ActionResult UploadImage([FromForm] ImageUploadRequest imageUploadRequest)
        {
            using var memoryStream = new MemoryStream();
            imageUploadRequest.Image.CopyTo(memoryStream);

            byte[] imageBytes = memoryStream.ToArray();
            return Ok();
        }
    }
}
