using DaTa.BL.BL;
using DaTa.BL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DaTa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaiKhoansController : ControllerBase
    {
        TaiKhoanBL taiKhoanBL;
        public TaiKhoansController(TaiKhoanBL bL)
        {
            taiKhoanBL = bL;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var data = taiKhoanBL.Get();
                return Ok(data);
            }
            catch (Exception ex)
            {

                throw (ex);
            }
        }
    }
}
