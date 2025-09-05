using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project_cls.DAL.DataAccess.Models;
using project_cls.Service_layer;
using project_cls.Service_layer.Dto.Employee;
using project_cls.Service_layer.Service_Contracts;


namespace project_cls.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public ActionResult AllEmployees()
        {
            return Ok(_employeeService.GetAll());
        }




        [HttpPost]
        public ActionResult Post(EmployeeInsertDto employee)
        {
            try
            {
                _employeeService.Insert(employee);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }




        [HttpGet("department/{departmentId}")]
        public IActionResult GetByDepartment(int departmentId)
        {
            var employees = _employeeService.GetByDepartmentId(departmentId);
            if (employees == null || !employees.Any())
                return NotFound();

            return Ok(employees);
        }

        [HttpPut("employees/update-password")]
        public IActionResult Update( EmployeeUpdateDto employeeUpdateDto)
        {
            _employeeService.Update(employeeUpdateDto);
            return Ok("Password updated successfully");
        }




        [HttpDelete]
        public ActionResult Delete(int id)
        {
            _employeeService.Delete(id);
            return Ok();
        }
    }
}
