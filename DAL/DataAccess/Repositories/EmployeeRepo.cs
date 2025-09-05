
using Microsoft.EntityFrameworkCore;
using project_cls.DAL.DataAccess.Models;
using project_cls.DAL.DataAcess_Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_cls.DAL.DataAccess.Repositories
{
    public class EmployeeRepo : BaseRepo<Employee>, IEmployeeRepo
    {
        public EmployeeRepo(AppDbContext db) : base(db)
        {
          
        }
        public override IEnumerable<Employee> GetAll()
        {
            return _dbSet
                .Include(Employee => Employee.Department);
        }




        public IEnumerable<Employee> FindByDepartmentId(int departmentId)
        {
            return _dbSet
                .Include(employee => employee.Department)
                .Where(employee => employee.DeptId == departmentId)
                .ToList();
        }

    }
}
