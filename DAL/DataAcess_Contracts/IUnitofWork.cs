using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_cls.DAL.DataAcess_Contracts
{
    public interface IUnitofWork
    {

        IEmployeeRepo EmployeeRepository { get; }

        IProductRepo ProductRepository { get; }
        IDepartmentRepo DepartmentRepository { get; }
        ICategoryRepo CategoryRepository { get; }
        IBillRepository BillRepository { get; }
        //IProductBillRepo ProductBillRepo { get; }

        void Save();
    }
}
