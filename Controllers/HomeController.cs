using Microsoft.AspNetCore.Mvc;

namespace programacao_aweb1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Boletim()
        {
            List<string> disciplinas = new List<string>
            {
                "Matemática",
                "Português",
                "História",
                "Geografia",
                "Ciências"
            };

            List<double> notas = new List<double>
            {
                8.5,
                7.0,
                5.5,
                9.0,
                6.0
            };

            ViewBag.Disciplinas = disciplinas;
            ViewBag.Notas = notas;

            return View();
        }
    }
}