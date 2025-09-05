using Microsoft.AspNetCore.Mvc;
using project_cls.Service_layer.Contracts;
using project_cls.Service_layer.Dto.Bill;
using System.Threading.Tasks;

namespace project_cls.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BillController : ControllerBase
    {
        private readonly IBillService _billService;

        public BillController(IBillService billService)
        {
            _billService = billService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBill([FromBody] BillInsertDto billDto)
        {
            if (billDto == null || !billDto.ProductBills.Any())
            {
                return BadRequest("Invalid bill data.");
            }

            try
            {
                _billService.Insert(billDto);
                return Ok("Bill created successfully.");
            }
            catch (Exception ex)
            {
                
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }



        [HttpGet]
        public ActionResult<IEnumerable<BillDto>> GetAll([FromQuery] DateTime? startDate, [FromQuery] DateTime? endDate)
        {
            var bills = _billService.GetAll(startDate, endDate);
            return Ok(bills);
        }
        [HttpGet("Statu")]
        public ActionResult<IEnumerable<BillDto>> GetBillsByState([FromQuery] bool? isDone)
        {
            var bills = _billService.GetBillsByState(isDone);
            return Ok(bills);
        }
        [HttpPut]
        public IActionResult Update (BillUpdateDto billUpdateDto)
        {
            _billService.Update(billUpdateDto);
            return Ok("Oreder is ready");
        }
    }
}
