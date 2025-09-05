using project_cls.DAL.DataAccess.Models;
using project_cls.DAL.DataAccess.Repositories;
using project_cls.DAL.DataAcess_Contracts;
using project_cls.Service_layer.Dto.Category;
using project_cls.Service_layer.Service_Contracts;

namespace project_cls.Service_layer.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitofWork _unitOfWork; 

        public CategoryService(IUnitofWork unitOfWork)
        {
            _unitOfWork = unitOfWork; 
        }

        public IEnumerable<CategoryDto> GetAll()
        {
            return _unitOfWork.CategoryRepository.GetAll()
                .Select(category => new CategoryDto
                {
                    CategoryId = category.CategoryId,
                    CategoryName = category.CategoryName,
                    
                });
        }



        public void Insert(CategoryInsertDto category )
        {
            var categories = new Category
            {
                
                CategoryName = category.CategoryName
            };
            _unitOfWork.CategoryRepository.Insert(categories); 
            _unitOfWork.Save();
        }


        public void Delete(int id)
        {
            _unitOfWork.CategoryRepository.Delete(id);
            _unitOfWork.Save();
        }




       


    }
}
