using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TWC_BACK_END.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("employeesgetall")]
        public IActionResult GetAll()
        {
            var result = _employeeService.GetList();

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet($"employeesgetbyid")]
        public IActionResult GetEmployeeById(int id)
        {
            var result = _employeeService.Get(id);

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("addemployee")]
        public IActionResult AddEmployee(Employee employee)
        {
            var result = _employeeService.Add(employee);

            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPut("updateemployee")]
        public IActionResult UpdateEmployee(Employee employee)
        {
            var result = _employeeService.Update(employee);

            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpDelete("deleteemployee")]
        public IActionResult DeleteEmployee(Employee employee)
        {
            var result = _employeeService.Delete(employee);

            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
