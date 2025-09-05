using project_cls.DAL.DataAccess.Models;
using project_cls.Service_layer.Dto.Department;

namespace project_cls.Service_layer.Service_Contracts
{
    public interface IDepartmentService
    {
        IEnumerable<Department> GetAll();
        //Department FindById(int id);
        void Insert(DepartmentInsertDto entity);
        //void Update(Department entity);
        void Delete(int id);
    }
}
