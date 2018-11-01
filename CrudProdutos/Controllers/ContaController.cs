using CrudProdutos.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudProdutos.Controllers
{
    public class ContaController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logar(Usuario usuario)
        {
            return Json("O CPF informado é inválido!");
        }
    }
}