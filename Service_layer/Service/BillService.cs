using project_cls.DAL.DataAccess.Models;
using project_cls.DAL.DataAccess.Repositories;
using project_cls.DAL.DataAcess_Contracts;
using project_cls.Service_layer.Contracts;
using project_cls.Service_layer.Dto.Bill;
using project_cls.Service_layer.Dto.ProductBill;

namespace project_cls.Service_layer.Service
{
    public class BillService : IBillService
    {
        private readonly IUnitofWork _UnitOfWork;
        public BillService(IUnitofWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }


        public void Insert(BillInsertDto billDto)
        {
            var bill = new Bill
            {
                Date = DateTime.Now,
                IsDone = false,
                ProductBills = new List<ProductBill>(),
                TotalPrice = 0
            };

            decimal totalPrice = 0;
            foreach (var productBillDto in billDto.ProductBills)
            {
                var product = _UnitOfWork.ProductRepository.FindById(productBillDto.ProductId);
                if (product != null)
                {
                    decimal productPrice = product.Price * productBillDto.Quantity;
                    totalPrice += productPrice;

                    var productBill = new ProductBill
                    {
                        ProductId = product.ProductId,
                        Bill = bill,
                        Quantity = productBillDto.Quantity
                    };

                    bill.ProductBills.Add(productBill);
                }
            }
            bill.TotalPrice = totalPrice;

            _UnitOfWork.BillRepository.Insert(bill);
            _UnitOfWork.Save();
        }






        public IEnumerable<BillDto> GetAll(DateTime? startDate = null, DateTime? endDate = null)
        {
            
            var billsQuery = _UnitOfWork.BillRepository.GetAll(); 

            
            if (startDate.HasValue)
            {
                billsQuery = billsQuery.Where(b => b.Date >= startDate.Value);
            }
            if (endDate.HasValue)
            {
                billsQuery = billsQuery.Where(b => b.Date <= endDate.Value);
            }

            
            return billsQuery.Select(b => new BillDto
            {
                BillId = b.BillId,
                Date = b.Date,
                TotalPrice = b.TotalPrice,
                IsDone = b.IsDone,
                ProductBills = b.ProductBills.Select(pb => new ProductBillDto
                {
                    ProductName = pb.Product.ProductName,
                    Quantity = pb.Quantity,
                    BillId = pb.BillId
                }).ToList()
            }).ToList();
        }

        public void Update(BillUpdateDto billUpdateDto)
        {
            var bill = _UnitOfWork.BillRepository.FindById(billUpdateDto.BillId );
            if (bill != null)
            {
                bill.IsDone = true;
            _UnitOfWork.Save();
            }

        }

        public IEnumerable<BillDto> GetBillsByState(bool? isDone = null)
        {
            var billsQuery = _UnitOfWork.BillRepository.GetAll();
            if (isDone.HasValue)
            {
                billsQuery = billsQuery.Where(b => b.IsDone == isDone.Value);
            }
            return billsQuery.Select(b => new BillDto
            {
                BillId = b.BillId,
                Date = b.Date,
                TotalPrice = b.TotalPrice,
                IsDone = b.IsDone,
                ProductBills = b.ProductBills.Select(pb => new ProductBillDto
                {
                    ProductName = pb.Product.ProductName,
                    Quantity = pb.Quantity,
                    BillId = pb.BillId
                }).ToList()
            }).ToList();
        }
    }
}
