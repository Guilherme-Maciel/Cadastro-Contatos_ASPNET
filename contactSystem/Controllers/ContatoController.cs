using contactSystem.Models;
using contactSystem.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace contactSystem.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepository _contatoRepository;
        public ContatoController(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }
        //Método principal da controller
        public IActionResult Index()
        {
            var contatos = _contatoRepository.GetAll();
            return View(contatos);
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
        [HttpPost]
        public IActionResult Add(ContatoModels contato)
        {
            _contatoRepository.Add(contato);
            return RedirectToAction("Index");
        }
    }
}
