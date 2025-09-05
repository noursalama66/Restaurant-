using project_cls.DAL.DataAccess.Models;
using project_cls.DAL.DataAcess_Contracts;
using project_cls.Service_layer.Service_Contracts;
using project_cls.Service_layer;
using project_cls.DAL.DataAccess.Repositories;
using project_cls.Service_layer.Dto.Product;

namespace project_cls.Service_layer.Service
{
    public class ProductService : IProductService
    {

        private readonly IUnitofWork _UnitOfWork;
        public ProductService(IUnitofWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }

        private IProductRepo _productRepository;
        //public IEnumerable<Product> GetAllProducts() => _productRepository.GetAll();


        public IEnumerable<ProductDto> GetAllProducts()
        {
            return _UnitOfWork.ProductRepository.GetAll()
                                .Select(product => new ProductDto
                                {
                                    ProductId = product.ProductId,
                                    ProductName = product.ProductName,
                                    Price = product.Price,
                                    Description = product.Description,
                                    Image = product.Image,
                                    CategoryName = product.Category != null ? product.Category.CategoryName : "No Category",
                                });
        }
        public ProductDto? GetProductById(int id)
        {
            var product = _UnitOfWork.ProductRepository.FindById(id);
            if (product != null)
            {
                return new ProductDto
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    Price = product.Price,
                    Description = product.Description,
                    Image = product.Image,
                    CategoryName = product.Category.CategoryName != null ? product.Category.CategoryName : "No Category",
                };
            }
            return null;
        }
        public void AddProduct(ProductInsertDto product)
        {
            var entity = new Product
            {
                ProductName = product.ProductName,
                Price = product.Price,
                Description = product.Description,
                Image = product.Image,
                CategoryId = product.CategoryId,
            };
            _UnitOfWork.ProductRepository.Insert(entity);
            _UnitOfWork.Save();
        }
        public void UpdateProduct(ProductUpdateDto product)
        {
            var entity = _UnitOfWork.ProductRepository.FindById(product.ProductId);
            if (entity != null)
            {
                entity.ProductName = product.ProductName;
                entity.Price = product.Price;
                entity.Description = product.Description;
                entity.Image = product.Image;
                entity.CategoryId = product.CategoryId;
                _UnitOfWork.ProductRepository.Update(entity);
                _UnitOfWork.Save();
            }
        }
        public void DeleteProduct(int id)
        {
            _UnitOfWork.ProductRepository.Delete(id);
            _UnitOfWork.Save();
        }


        public IEnumerable<ProductDto> GetProductsByCategory(int categoryId)
        {
            var products = _UnitOfWork.ProductRepository.GetByCategory(categoryId);

            return products.Select(product => new ProductDto
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                Price = product.Price,
                Description = product.Description,
                Image = product.Image,
                CategoryName = product.Category != null ? product.Category.CategoryName : "No Category",
            });
        }
    }
}
