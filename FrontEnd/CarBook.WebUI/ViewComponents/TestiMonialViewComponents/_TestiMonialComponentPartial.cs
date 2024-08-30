using CarBook.Dtos.TestiMonialDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.TestiMonialViewComponents
{
	public class _TestiMonialComponentPartial : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;
        public _TestiMonialComponentPartial(IHttpClientFactory httpClientFactory) => _httpClientFactory = httpClientFactory;
        public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var ResponseMessage = await client.GetAsync("https://localhost:7114/api/TestiMonial");
			if (ResponseMessage.IsSuccessStatusCode)
			{
				var jsondata = await ResponseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<IEnumerable<ResultTestiMonialDtos>>(jsondata);
				return View(values);
			}
			return View();
		}
	}
}
