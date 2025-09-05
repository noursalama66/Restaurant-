using project_cls.DAL.DataAccess.Models;
using project_cls.Service_layer.Dto.Bill;

namespace project_cls.Service_layer.Contracts
{
    public interface IBillService
    {
        IEnumerable<BillDto> GetAll(DateTime? startDate = null, DateTime? endDate = null);
        IEnumerable<BillDto> GetBillsByState(bool? isDone = null);
        void Insert(BillInsertDto entity);
        void Update(BillUpdateDto entity);

    }
}
