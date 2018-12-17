using Intro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa() {
                PessoaId = 1,
                Nome = "Pedro",
                Tipo = "Dev"
            };

            ViewBag.id = pessoa.PessoaId;
            ViewBag.nome = pessoa.Nome;
            ViewBag.tipo = pessoa.Tipo;
            return View(pessoa);
        }

        public ActionResult Contatos() {
            return View();
        }
        [HttpPost]
        public ActionResult Lista() {
            return View();
        }
    }
}