using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace T3H_Cap03_P1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PaginaNova()
        {
            // Informações enviadas da Controller

            ViewBag.Codigo = "1";
            ViewBag.Nome = "Joao";

            ViewData["Endereco"] = "R. Alguma Coisa";
            ViewData["Estado"] = "SP";

            return View();
        }

        public string Mensagem()
        {
            return "Olá Mundo!!!!";
        }

        public string Integracao()
        {
            return "<Nome>Joao da Silva</Nome>";
        }

    }
}


