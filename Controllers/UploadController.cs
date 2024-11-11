using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace autoSpa_backend.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public UploadController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile(IFormFile upload)
        {
            if (upload == null || upload.Length == 0)
            {
                return BadRequest("No file uploaded.");
            }

            // Lấy đường dẫn lưu ảnh trên server
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads", upload.FileName);

            // Tạo thư mục uploads nếu chưa tồn tại
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }

            // Lưu file vào server
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await upload.CopyToAsync(stream);
            }

            // Trả về URL của file đã upload để CKEditor sử dụng
            return Ok(new { url = "https://localhost:7115/uploads/" + upload.FileName });
        }
    }
}
