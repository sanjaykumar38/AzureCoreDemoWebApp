using Microsoft.AspNetCore.Mvc;

namespace AzureCoreDemoWebApp.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
