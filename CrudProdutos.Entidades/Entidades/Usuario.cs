using System;
using System.Collections.Generic;
using System.Text;

namespace CrudProdutos.Entidades.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }

        public string ContaUsuario { get; set; }

        public string Senha { get; set; }

        public string Perfil { get; set; }
    }
}
