using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TWC_BACK_END.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        private IAdminService _adminService;

        public AdminsController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet("admingetall")]
        public IActionResult GetAll()
        {
            var result = _adminService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet($"admingetbyid")]
        public IActionResult GetAdminById(int id)
        {
            var result = _adminService.Get(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("addadmin")]
        public IActionResult AddAdmin(Admin admin)
        {
            var result = _adminService.Add(admin);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("updateadmin")]
        public IActionResult UpdateAdmin(Admin admin)
        {
            var result = _adminService.Update(admin);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete("deleteadmin")]
        public IActionResult DeleteAdmin(Admin admin)
        {
            var result = _adminService.Delete(admin);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}