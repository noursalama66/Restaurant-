using project_cls.DAL.DataAccess.Models;
using project_cls.Service_layer.Dto.Product;

namespace project_cls.Service_layer.Service_Contracts
{
    public interface IProductService
    {
        IEnumerable<ProductDto> GetAllProducts();
        ProductDto GetProductById(int id);
        IEnumerable<ProductDto> GetProductsByCategory(int categoryId);
        
        void AddProduct(ProductInsertDto product);
        void UpdateProduct(ProductUpdateDto product);
        void DeleteProduct(int id);
    }
}

