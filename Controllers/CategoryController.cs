using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project_cls.DAL.DataAccess.Models;
using project_cls.Service_layer;
using project_cls.Service_layer.Dto.Category;
using project_cls.Service_layer.Service_Contracts;


namespace project_cls.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("All")]
        public ActionResult AllCategories()
        {
            return Ok(_categoryService.GetAll());
        }




        [HttpPost("insert")]
        public ActionResult Post(CategoryInsertDto category)
        {
            try
            {
                _categoryService.Insert(category);
                return Ok("Category added successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }




        [HttpDelete]
        public ActionResult Delete(int id)
        {
            _categoryService.Delete(id);
            return Ok();
        }
    





 

}
}
