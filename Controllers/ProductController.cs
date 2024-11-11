using Application.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace autoSpa_backend.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("list")]
        public IActionResult GetPaging()
        {
            var data = _productService.GetPaging();
            return Ok(data);
        }
        [HttpPost("detail")]
        public IActionResult GetById(Guid id)
        {
            var data = _productService.GetById(id);
            return Ok(data);
        }
        [HttpGet("token")]
        public IActionResult GetToken(Guid id)
        {
            var data = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VyIjp7ImlkIjoxLCJ1c2VybmFtZSI6ImV4YW1wbGVfdXNlciIsInJvbGUiOiJhZG1pbiJ9LCJleHAiOjE3MzEzNTAxMDN9.pPX5d5t1o-D7L-aGPOi0xucbt_cbrwv6RuBZRK8yLgg";
            return Ok(data);
        }
    }
}
