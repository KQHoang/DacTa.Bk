using DaTa.BL.BL;
using DaTa.BL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DaTa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductBL productBL;
        public ProductController(ProductBL bL)
        {
            productBL = bL;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var data = productBL.Get();
                return Ok(data);
            }
            catch (Exception ex)
            {

                throw(ex);
            }
        }

        [HttpPost]
        public IActionResult Post(SanPham sanPham)
        {
            try
            {
                var res = productBL.Insert(sanPham);
                return StatusCode(201, res);
            }
            catch (Exception ex)
            {

                throw(ex);
            }
        }
    }
}
