using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        
        public ProductController()
        {
            
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromRoute] long id)
        {
            return Ok("GetById");
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            return Ok("Post");
        }

        [HttpPut]
        public async Task<IActionResult> Put()
        {
            return Ok("Put");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete()
        {
            return Ok("Delete");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BuscarPorId()
        {
            return Ok("BuscarPorId");
        }
    }

}