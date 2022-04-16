using Microsoft.AspNetCore.Mvc;

namespace contactSystem.Controllers
{
    public class ContatoController : Controller
    {
        //Método principal da controller
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Excluir()
        {
            return View();
        }
    }
}
