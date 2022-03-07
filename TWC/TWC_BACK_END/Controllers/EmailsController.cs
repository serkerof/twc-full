using Entities.Concrete;
using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TWC_BACK_END.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailsController : ControllerBase
    {

        private IEmailService _emailService;

        public EmailsController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpGet("emailgetall")]
        public IActionResult GetAll()
        {
            var result = _emailService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet($"emailgetbyid")]
        public IActionResult GetEmailById(int id)
        {
            var result = _emailService.Get(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("addemail")]
        public IActionResult AddEmail(Email email)
        {
            var result = _emailService.Add(email);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("updateemail")]
        public IActionResult UpdateEmail(Email email)
        {
            var result = _emailService.Update(email);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete("deleteemail")]
        public IActionResult DeleteEmail(Email email)
        {
            var result = _emailService.Delete(email);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
