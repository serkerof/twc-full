using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TWC_BACK_END.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private IServiceService _serviceService;

        public ServicesController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet("servicesgetall")]
        public IActionResult GetAll()
        {
            var result = _serviceService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet($"servicesgetbyid")]
        public IActionResult GetServiceById(int id)
        {
            var result = _serviceService.Get(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("addservice")]
        public IActionResult AddService(Service service)
        {
            var result = _serviceService.Add(service);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("updateservice")]
        public IActionResult UpdateService(Service service)
        {
            var result = _serviceService.Update(service);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete("deleteservice")]
        public IActionResult DeleteService(Service service)
        {
            var result = _serviceService.Delete(service);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}