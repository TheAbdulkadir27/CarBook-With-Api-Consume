using CarBook.Dtos.CarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace CarBook.WebUI.Controllers
{
    public class CarController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public CarController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.V1 = "Araçlarımız";
            ViewBag.V2 = "Aracınızı Seçiniz";
            var client = _httpClientFactory.CreateClient();
            var ResponseMessage = await client.GetAsync("https://localhost:7114/api/CarPricing");
            if (ResponseMessage.IsSuccessStatusCode)
            {
                var jsondata = await ResponseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<IEnumerable<GetCarPricingWithCarDto>>(jsondata);
                return View(values);
            }
            return View();
        }
    }
}
