using CrudProdutos.Data.Repositorios;
using CrudProdutos.WebAPI.Models;
using System.Web.Mvc;

namespace CrudProdutos.WebAPI.Controllers
{
    public class AccountController : Controller
    {
        private UsuarioRepositorio usuarioRepositorio;

        public AccountController()
        {
            usuarioRepositorio = new UsuarioRepositorio();
        }

        public ActionResult Login(Usuario usuario)
        {
            var admin = usuarioRepositorio.Login(usuario.ContaUsuario, usuario.Senha);

            return View();
        }

    }
}