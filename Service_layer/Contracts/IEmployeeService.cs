using project_cls.DAL.DataAccess.Models;
using project_cls.Service_layer.Dto.Employee;


namespace project_cls.Service_layer.Service_Contracts
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeDto> GetAll();
        EmployeeDto FindById(int id);
        IEnumerable<EmployeeDto> GetByDepartmentId(int departmentId);
        void Insert(EmployeeInsertDto employee);
        void Update(EmployeeUpdateDto employee);
        //void UpdatePassword(EmployeeUpdateDto employeeUpdateDto);
        void Delete(int id);
    }
}
