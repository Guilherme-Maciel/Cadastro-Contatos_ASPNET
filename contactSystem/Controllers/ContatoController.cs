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
        public IActionResult Editar(int id)
        {
            ContatoModels contato = _contatoRepository.Get(id);
            return View(contato);
        }
        public IActionResult Excluir(int id)
        {
            ContatoModels contato = _contatoRepository.Get(id);
            return View(contato);
        }


        //HTTP METHODS
        [HttpPost]
        public IActionResult Add(ContatoModels contato)
        {
            _contatoRepository.Add(contato);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alter(ContatoModels contato)
        {
            _contatoRepository.Alter(contato);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            _contatoRepository.Delete(id);
            return RedirectToAction("Index");

        }

    }
}
