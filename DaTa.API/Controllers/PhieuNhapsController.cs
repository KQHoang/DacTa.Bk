using DaTa.BL.BL;
using DaTa.BL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DaTa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhieuNhapsController : ControllerBase
    {
        PhieuNhapBL phieuNhapBL;

        public PhieuNhapsController(PhieuNhapBL phieuNhapBL)
        {
            this.phieuNhapBL = phieuNhapBL;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var data = phieuNhapBL.Get();
                return Ok(data);
            }
            catch (Exception ex)
            {

                throw (ex);
            }
        }

        [HttpPost]
        public IActionResult Post(PhieuNhap phieuNhap)
        {
            try
            {
                var res = phieuNhapBL.Insert(phieuNhap);
                return StatusCode(201, res);
            }
            catch (Exception ex)
            {

                throw (ex);
            }
        }

        [HttpGet("/Max")]
        public IActionResult GetIdMax()
        {
            try
            {
                var data = phieuNhapBL.getPhieuNhapIdMax();
                return Ok(data);
            }
            catch (Exception ex)
            {

                throw (ex);
            }
        }
    }
        
}
