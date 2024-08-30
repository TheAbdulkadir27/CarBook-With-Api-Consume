using CarBook.Dtos.Contact;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateContactDto createContact)
        {
            var client = _httpClientFactory.CreateClient();
            createContact.SendDate = DateTime.Now;
            var jsondata = JsonConvert.SerializeObject(createContact);
            StringContent stringContent = new StringContent(jsondata, Encoding.UTF8, "application/json");
            var MessageResponse = await client.PostAsync("https://localhost:7114/api/Contact", stringContent);
            if (MessageResponse.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}
