using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TWC_BACK_END.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("ordergetall")]
        public IActionResult GetAll()
        {
            var result = _orderService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet($"ordergetbyid")]
        public IActionResult GetOrderById(int id)
        {
            var result = _orderService.Get(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("addorder")]
        public IActionResult AddOrder(Order order)
        {
            var result = _orderService.Add(order);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("updateorder")]
        public IActionResult UpdateOrder(Order order)
        {
            var result = _orderService.Update(order);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete("deleteorder")]
        public IActionResult DeleteOrder(Order order)
        {
            var result = _orderService.Delete(order);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}