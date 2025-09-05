using project_cls.DAL.DataAccess.Models;

namespace project_cls.Service_layer.Dto.Product
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }


    }
}
