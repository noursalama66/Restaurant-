
using project_cls.Service_layer.Dto.ProductBill;
namespace project_cls.Service_layer.Dto.Bill
{






    public class BillDto
    {
        public int BillId { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsDone { get; set; }
        public DateTime Date { get; set; }
        public List<ProductBillDto> ProductBills { get; set; }
    }
}