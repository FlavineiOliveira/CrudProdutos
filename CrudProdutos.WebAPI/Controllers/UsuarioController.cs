using CrudProdutos.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CrudProdutos.WebAPI
{
    public class UsuarioController : ApiController
    {
        private readonly Usuario [] Usuario = new Usuario[2] {
                new Usuario { Id = 1, ContaUsuario = "admin", Senha = "admin", Perfil = "Gestor" },
                new Usuario { Id = 2, ContaUsuario = "convidado", Senha = "", Perfil = "Convidado" }
        };

        // GET api/<controller>
        public IEnumerable<Usuario> Get()
        {
            return Usuario;
        }

        // GET api/<controller>/5
        public Usuario Get(int id)
        {
            var usuariosAPI = Usuario;

            return usuariosAPI.SingleOrDefault(x => x.Id == id);
        }

        public Usuario Logar(string usuarioLogin, string senhaLogin)
        {
            var usuariosAPI = Usuario;

            var usuario = usuariosAPI.SingleOrDefault(x => x.ContaUsuario == usuarioLogin );

            if (usuario.Senha == senhaLogin)
                return new Usuario() { ContaUsuario = "Logado" };

            return new Usuario() { ContaUsuario = "Error" };
        }
    }
}