using CarBook.Dtos.CarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace CarBook.WebUI.ViewComponents.DefaultViewComponent
{
    public class _DefaultGetLast5CarsWithBrandComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DefaultGetLast5CarsWithBrandComponentPartial(IHttpClientFactory httpClientFactory) => _httpClientFactory = httpClientFactory;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var ResponseMessage = await client.GetAsync("https://localhost:7114/api/Car/GetLast5CarWithBrand");
            if (ResponseMessage.IsSuccessStatusCode)
            {
                var content = await ResponseMessage.Content.ReadAsStringAsync();
                var JsonData = JsonConvert.DeserializeObject<IEnumerable<ResultGetLast5CarsWithBrandDtos>>(content);
                return View(JsonData);
            }
            return View();
        }
    }
}
