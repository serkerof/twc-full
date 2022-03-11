using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TWC_BACK_END.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("usergetall")]
        public IActionResult GetAll()
        {
            var result = _userService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet($"usergetbyid")]
        public IActionResult GetUserById(int id)
        {
            var result = _userService.Get(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("adduser")]
        public IActionResult AddUser(User user)
        {
            var result = _userService.Add(user);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("updateuser")]
        public IActionResult UpdateUser(User user)
        {
            var result = _userService.Update(user);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete("deleteuser")]
        public IActionResult DeleteUser(User user)
        {
            var result = _userService.Delete(user);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}