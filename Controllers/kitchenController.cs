using FinalProject.Models.Dto.Bill;
using FinalProject.Models.Dto.ProductBill;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class kitchenController : Controller
    {

        private readonly HttpClient _httpClient;

        public kitchenController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IActionResult> Index()
        {
            var bills = new List<BillDto>();

            var response = await _httpClient.GetAsync("http://localhost:5024/api/Bill");

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                // Log the error content for debugging
                return NotFound();
            }

            bills = await response.Content.ReadFromJsonAsync<List<BillDto>>();

            return View(bills);
        }
    }
}
