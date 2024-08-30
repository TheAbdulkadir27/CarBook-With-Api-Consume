using CarBook.Dtos.FooterAddressDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace CarBook.WebUI.ViewComponents.FooterAddressViewComponents
{
    [ViewComponent(Name = "_FooterAddressViewComponentPartial")]
    public class _FooterAddressViewComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _FooterAddressViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7114/api/FooterAddress");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsondata = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<IEnumerable<ResultFooterAddressDtos>>(jsondata);
                return View(values);
            }
            return View();
        }
    }
}
