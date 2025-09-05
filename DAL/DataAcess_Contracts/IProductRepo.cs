
using project_cls.DAL.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_cls.DAL.DataAcess_Contracts
{
    public interface IProductRepo : IBaseRepo<Product>
    {
        IEnumerable<Product> GetByCategory(int categoryId);
    }
}