using CarBook.Dtos.BlogDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
namespace CarBook.WebUI.ViewComponents.BlogViewComponent
{
    public class GetLast3BlogWithAuthorListComponentsPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpclientfactory;
        public GetLast3BlogWithAuthorListComponentsPartial(IHttpClientFactory httpclientfactory) => _httpclientfactory = httpclientfactory;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpclientfactory.CreateClient();
            var response = await client.GetAsync("https://localhost:7114/api/Blog/GetLast3BlogsWithAuthor");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<IEnumerable<ResultLastBlogWithAuthorDtos>>(content);
                return View(values);
            }
            return View();
        }
    }
}
