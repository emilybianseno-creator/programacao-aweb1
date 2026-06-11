using Microsoft.AspNetCore.Mvc;

namespace programacao_aweb1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}