using CarBook.Dtos.BannerDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace CarBook.WebUI.ViewComponents.DefaultViewComponent
{
    public class _DefaultCoverUILayoutComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DefaultCoverUILayoutComponentPartial(IHttpClientFactory httpClientFactory) => _httpClientFactory = httpClientFactory;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var ResponseMessage = await client.GetAsync("https://localhost:7114/api/Banner");
            if (ResponseMessage.IsSuccessStatusCode)
            {
                var content = await ResponseMessage.Content.ReadAsStringAsync();
                var JsonData = JsonConvert.DeserializeObject<IEnumerable<ResultBannerDtos>>(content);
                return View(JsonData);
            }
            return View();
        }
    }
}
