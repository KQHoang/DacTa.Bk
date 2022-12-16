using DaTa.BL.BL;
using DaTa.BL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DaTa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CTPhieuNhapsController : ControllerBase
    {
        CT_PhieuNhapBL cTPhieuNhapBL;

        public CTPhieuNhapsController(CT_PhieuNhapBL cTPhieuNhapBL)
        {
            this.cTPhieuNhapBL = cTPhieuNhapBL;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var data = cTPhieuNhapBL.Get();
                return Ok(data);
            }
            catch (Exception ex)
            {

                throw (ex);
            }
        }

        [HttpPost]
        public IActionResult Post(CT_PhieuNhap cTPhieuNhap)
        {
            try
            {
                var res = cTPhieuNhapBL.Insert(cTPhieuNhap);
                return StatusCode(201, res);
            }
            catch (Exception ex)
            {

                throw (ex);
            }
        }
    }
}
