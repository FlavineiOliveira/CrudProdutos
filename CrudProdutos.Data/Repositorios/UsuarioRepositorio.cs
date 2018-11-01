using CrudProdutos.Entidades.Entidades;
using System.Linq;

namespace CrudProdutos.Data.Repositorios
{
    public class UsuarioRepositorio : RepositorioBase
    {
        public Usuario Login (string conta, string senha)
        {
            if (string.IsNullOrEmpty(conta) || string.IsNullOrEmpty(senha))
                return null;

            using (Db)
            {
                return Db.Usuarios.Where(x => x.ContaUsuario == conta && x.Senha == senha).SingleOrDefault();
            }
                
        }
    }
}
