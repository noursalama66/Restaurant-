using project_cls.DAL.DataAcess_Contracts;
using project_cls.Service_layer.Dto.Department;
using project_cls.DAL.DataAccess.Models;
using project_cls.DAL.DataAccess.Repositories;
//using project_cls.Service_layer.Dto.Employee;
using project_cls.Service_layer.Service_Contracts;

namespace project_cls.Service_layer.Service
{
    public class DepartmentService: IDepartmentService
    {




        private readonly IUnitofWork _unitOfWork;

        public DepartmentService(IUnitofWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Department> GetAll()
        {
            return _unitOfWork.DepartmentRepository.GetAll()
                .Select(department => new Department
                {
                    DeptId= department.DeptId,
                    DeptName = department.DeptName

                });
        }




        public void Insert(DepartmentInsertDto department)
        {
            var departments = new Department
            {
                    DeptName = department.DeptName

            };

            _unitOfWork.DepartmentRepository.Insert(departments);
            _unitOfWork.Save();
        }




        public void Delete(int id)
        {
            _unitOfWork.DepartmentRepository.Delete(id);
            _unitOfWork.Save();
        }
    }
}
