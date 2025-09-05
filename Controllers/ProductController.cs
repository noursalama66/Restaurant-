using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project_cls.DAL.DataAccess.Models;
using project_cls.Service_layer;
using project_cls.Service_layer.Dto.Product;
using project_cls.Service_layer.Service_Contracts;

namespace project_cls.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult AllProducts()
        {
            return Ok(_productService.GetAllProducts());
        }

        [HttpPost]
        public ActionResult Post(ProductInsertDto product)
        {
            try
            {
                _productService.AddProduct(product);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut]
        public ActionResult Update(ProductUpdateDto product)
        {
            _productService.UpdateProduct(product);
            return Ok();
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            _productService.DeleteProduct(id);
            return Ok();
        }

        [HttpGet("GetProductsByCategory/{categoryId}")]
        public ActionResult<IEnumerable<ProductDto>> GetProductsByCategory(int categoryId)
        {
            var products = _productService.GetProductsByCategory(categoryId);

            if (products == null || !products.Any())
            {
                return NotFound("No products found for this category.");
            }

            return Ok(products);
        }

    }
}
