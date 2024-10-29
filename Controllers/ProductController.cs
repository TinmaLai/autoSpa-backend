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
    }
}
