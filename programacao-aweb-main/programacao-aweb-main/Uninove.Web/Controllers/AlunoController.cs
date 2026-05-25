using Microsoft.AspNetCore.Mvc;

namespace Uninove.Web.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nome = "Rodolfo";
            ViewBag.Curso = "Tecnologia em Análise e Desenvolvimento de Sistemas";
            ViewBag.Semestre = "1º semestre";

            return View();
        }

        public IActionResult Detalhes(int id)
        {
            ViewBag.Id = id;

            return View();
        }
    }
}