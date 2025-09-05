using project_cls.DAL.DataAccess.Models;
using project_cls.Service_layer.Dto.Category;


namespace project_cls.Service_layer.Service_Contracts
{
    public interface ICategoryService
    {
        //IEnumerable<Category> GetAll();
        //Category FindById(int id);
        void Insert(CategoryInsertDto category);
        IEnumerable<CategoryDto> GetAll(); // Return a list of CategoryDto

        //void Update(Category entity);
        void Delete(int id);
    }




}
