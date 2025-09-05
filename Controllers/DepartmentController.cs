using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project_cls.DAL.DataAccess.Models;
using project_cls.Service_layer;
using project_cls.Service_layer.Dto.Department;

using project_cls.Service_layer.Service_Contracts;


namespace project_cls.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepatmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepatmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet("All")]
        public ActionResult AllCategories()
        {
            return Ok(_departmentService.GetAll());
        }




        [HttpPost("insert")]
        public ActionResult Post(DepartmentInsertDto department)
        {
            try
            {
                _departmentService.Insert(department);
                return Ok("department added successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            _departmentService.Delete(id);
            return Ok();
        }
    




}
}
