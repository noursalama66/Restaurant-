using Microsoft.EntityFrameworkCore;
using project_cls.DAL.DataAccess.Models;
using project_cls.DAL.DataAcess_Contracts;
using project_cls.Service_layer.Dto.Bill;

namespace project_cls.DAL.DataAccess.Repositories
{
    public class BillRepository : BaseRepo<Bill>, IBillRepository
    {
        public BillRepository(AppDbContext db) : base(db)
        {
        }
        //public override IEnumerable<Bill> GetAll()
        //{
        //    return _dbSet
        //        .Include(bill => bill.ProductBills)
        //        .ThenInclude(pb => pb.Product);

        //}
        public override IQueryable<Bill> GetAll()
        {
            return _dbSet
                .Include(bill => bill.ProductBills)
                .ThenInclude(pb => pb.Product)
                .AsQueryable(); // Ensure the query is IQueryable
        }

    }
}
