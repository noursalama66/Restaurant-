using project_cls.DAL.DataAccess.Models;
using project_cls.Service_layer.Dto.ProductBill;

namespace project_cls.DAL.DataAcess_Contracts
{
    public interface IProductBillRepo : IBaseRepo<ProductBill>
    {
        //public IEnumerable<ProductBillDto> GetBillsByDate(DateTime date);
        //public IEnumerable<ProductBillDto> GetBillsById(int idProduct, int idBill);


    }
}
