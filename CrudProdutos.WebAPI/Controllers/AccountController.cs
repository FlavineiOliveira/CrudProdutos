using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudProdutos.Data.Repositorios;
using CrudProdutos.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudProdutos.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        UsuarioRepositorio usuarioRepositorio;

        public AccountController()
        {
            usuarioRepositorio = new UsuarioRepositorio();
        }

        [HttpPost]
        public Usuario Login ([FromBody]Usuario usuario)
        {
            var consulta = usuarioRepositorio.Login(usuario.Conta, usuario.Senha);

            usuario.Conta = consulta.ContaUsuario;
            usuario.Senha = consulta.Senha;

            return usuario;
        }
    }
}