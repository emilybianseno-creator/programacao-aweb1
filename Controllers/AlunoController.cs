using Microsoft.AspNetCore.Mvc;

namespace programacao_aweb.Controllers
{
    public class AlunoController : Controller
    {
    public IActionResult Index()
        {
            ViewBag.Nome = "Emily";
            ViewBag.Curso = "ADS";
            ViewBag.Semestre = "1º Semestre";

            return View();
        }
    }
}
