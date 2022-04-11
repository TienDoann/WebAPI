using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.services;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class loaisController : ControllerBase
    {
        private readonly ILoaiRepository _loaiRepository;

        public loaisController(ILoaiRepository loaiRepository)
        {
            _loaiRepository = loaiRepository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_loaiRepository.GetAll());
        }
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            var data = _loaiRepository.GetById(id);
            if(data != null)
            {
                return Ok(data);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut("id")]
        public IActionResult Update(int id, LoaiVM models)
        {
            if( id != models.Id)
            {
                return BadRequest();
            }
            try
            {
                _loaiRepository.Update(models);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
            
        }
        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            _loaiRepository.Delete(id);
            return NoContent();
        }
        [HttpPost]
        public IActionResult Add(LoaiModels loai)
        {
            return Ok(_loaiRepository.Add(loai));
        }
    }
}
