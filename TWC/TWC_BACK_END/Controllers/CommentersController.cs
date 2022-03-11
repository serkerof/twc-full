using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TWC_BACK_END.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentersController : ControllerBase
    {
        private ICommenterService _commenterService;

        public CommentersController(ICommenterService commenterService)
        {
            _commenterService = commenterService;
        }

        [HttpGet("commentergetall")]
        public IActionResult GetAll()
        {
            var result = _commenterService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet($"commentergetbyid")]
        public IActionResult GetCommenterById(int id)
        {
            var result = _commenterService.Get(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("addcommenter")]
        public IActionResult AddCommenter(Commenter commenter)
        {
            var result = _commenterService.Add(commenter);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("updatecommenter")]
        public IActionResult UpdateCommenter(Commenter commenter)
        {
            var result = _commenterService.Update(commenter);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete("deletecommenter")]
        public IActionResult DeleteCommenter(Commenter commenter)
        {
            var result = _commenterService.Delete(commenter);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}