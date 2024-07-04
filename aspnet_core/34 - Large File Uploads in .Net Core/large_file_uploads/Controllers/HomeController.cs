using Microsoft.AspNetCore.Mvc;

namespace large_file_uploads.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("File not selected");
            }

            var filePath = Path.Combine("uploads", file.FileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return Ok(new { filePath });
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadChunk(IFormFile file, [FromForm] string fileName, [FromForm] long start, [FromForm] long end)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("Chunk not selected");
            }

            var filePath = Path.Combine("uploads", fileName);

            using (var stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                stream.Seek(start, SeekOrigin.Begin);
                await file.CopyToAsync(stream);
            }

            return Ok();
        }
    }
}
