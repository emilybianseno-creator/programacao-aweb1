using Microsoft.AspNetCore.Mvc;

namespace programacao_aweb1.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            List<string> produtos = new List<string>
            {
                "Notebook",
                "Mouse",
                "Teclado",
                "Monitor",
                "Headset"
            };

            List<double> precos = new List<double>
            {
                3500,
                80,
                150,
                900,
                250
            };

            ViewBag.Produtos = produtos;
            ViewBag.Precos = precos;

            return View();
        }
    }
}