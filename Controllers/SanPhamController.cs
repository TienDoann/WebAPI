using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WebAPI.Models;
using WebAPI.services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        private readonly IHangHoaReponsitory _hangHoaReponsitory;

        public SanPhamController(IHangHoaReponsitory hangHoaReponsitory)
        {
            _hangHoaReponsitory = hangHoaReponsitory;
        }

        [HttpGet]
        public IActionResult GetAllSP(string search,double? from, double? to)
        {
            var result =_hangHoaReponsitory.GetAll(search,from,to);
            return Ok(result);
        }
        [HttpGet("id")]
        public IActionResult Search(Guid id)
        {
            var data = _hangHoaReponsitory.Search(id);
            if(data != null)
            {
                return Ok(data);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public IActionResult Add(HangHoaModel model)
        {
            return Ok(_hangHoaReponsitory.Add(model)    );
        }
    }
}
