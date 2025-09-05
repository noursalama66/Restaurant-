using project_cls.DAL.DataAccess.Models;
using project_cls.DAL.DataAcess_Contracts;
using project_cls.Service_layer.Service_Contracts;
using project_cls.Service_layer.Dto.Employee;
using System.Collections.Generic;

namespace project_cls.Service_layer.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitofWork _UnitOfWork;
        public EmployeeService(IUnitofWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }

        private IEmployeeRepo _EmployeeRepository;
        


        public IEnumerable<EmployeeDto> GetAll()
        {
            return _UnitOfWork.EmployeeRepository.GetAll()
                                .Select(employee => new EmployeeDto
                                {
                                    EmpId = employee.EmpId,
                                    EmpName = employee.EmpName,
                                    
                                    Position = employee.Position,
                                    username = employee.username,
                                    password= employee.password,
                                    salary = employee.salary,



                                    DeptName = employee.Department != null ?employee.Department.DeptName : "No Department",
                                });
        }

        public EmployeeDto FindById(int id)
        {
            var employee = _UnitOfWork.EmployeeRepository.FindById(id);
            if (employee == null)
                return null;

            return new EmployeeDto
            {
                EmpId = employee.EmpId,
                EmpName = employee.EmpName,
                Position = employee.Position,
                username = employee.username,
                password = employee.password,
                salary = employee.salary,
                DeptName = employee.Department?.DeptName ?? "No Department"
            };
        }

        public void Insert(EmployeeInsertDto employeeDto)
        {
            var employee = new Employee
            {
                
                EmpName = employeeDto.EmpName,
                Position = employeeDto.postion,
                username = employeeDto.username,
                password = employeeDto.password,
                salary = employeeDto.salary,
                DeptId =employeeDto.DeptId
               
                
            };

            _UnitOfWork.EmployeeRepository.Insert(employee);
            _UnitOfWork.Save();
        }


        public void Update(EmployeeUpdateDto employeeUpdateDto)
        {
            var employee = _UnitOfWork.EmployeeRepository.FindById(employeeUpdateDto.EmpId);
            if (employee != null)
            {
                employee.password = employeeUpdateDto.Password;
                _UnitOfWork.EmployeeRepository.Update(employee);
                _UnitOfWork.Save();
            }
        }
        public void Delete(int id)
        {
            _UnitOfWork.EmployeeRepository.Delete(id);
            _UnitOfWork.Save();
        }


        public IEnumerable<EmployeeDto> GetByDepartmentId(int departmentId)
        {
            return _UnitOfWork.EmployeeRepository.FindByDepartmentId(departmentId)
                        .Select(employee => new EmployeeDto
                        {
                            EmpId = employee.EmpId,
                            EmpName = employee.EmpName,
                            Position = employee.Position,
                            username = employee.username,
                            password = employee.password,
                            salary = employee.salary,


                            DeptName = employee.Department?.DeptName ?? "No Department"
                        });
        }
    }
}
