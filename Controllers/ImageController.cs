
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project_cls.DAL;
using System;

namespace project_cls.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {



        private readonly AppDbContext _db; // Assuming `AppDbContext` is your database context
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ImageController(AppDbContext db, IWebHostEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost("product-image")]
        public IActionResult UploadProductImage([FromForm] int productId, IFormFile file)
        {
            var product = _db.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product == null)
                return NotFound("Product not found");

            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded");

            // Generate a unique filename for the uploaded file
            var uniqueFileName = $"{Guid.NewGuid()}_{file.FileName}";
            var uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
            var filePath = Path.Combine(uploadsFolder, uniqueFileName);

            // Ensure the uploads folder exists
            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            // Save the uploaded file to the uploads folder
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            // Update the product's image path in the database
            var imageUrl = Path.Combine("images", uniqueFileName);
            product.Image = imageUrl;
            _db.SaveChanges();

            // Return the full URL of the uploaded image
            //var imageUrl = Path.Combine("images", uniqueFileName);
            return Ok(new { ImageUrl = imageUrl });
        }


    }
}
