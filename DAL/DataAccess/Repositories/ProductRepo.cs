
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using project_cls.DAL.DataAccess.Models;
using project_cls.DAL.DataAcess_Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace project_cls.DAL.DataAccess.Repositories
{
    public class ProductRepo : BaseRepo<Product>, IProductRepo
    {
        public ProductRepo(AppDbContext db) : base(db)
        {
        }
        public override IEnumerable<Product> GetAll()
        {
            return _dbSet
                .Include(Product => Product.Category);


        }
        public IEnumerable<Product> GetByCategory(int categoryId)
        {
            return _dbSet
                .Include(product => product.Category)
                .Where(product => product.CategoryId == categoryId)
                .ToList();
        }

    }
}
