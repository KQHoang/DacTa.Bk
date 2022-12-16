using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DaTa.BL.BL;

namespace DaTa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThuongHieusController : ControllerBase
    {
        ThuongHieuBL thuongHieuBL;
        public ThuongHieusController(ThuongHieuBL bL)
        {
            thuongHieuBL = bL;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var data = thuongHieuBL.Get();
                return Ok(data);
            }
            catch (Exception ex)
            {

                throw (ex);
            }
        }
    }
}
