using System.Runtime.Remoting.Contexts;

namespace CrudProdutos.Data.Repositorios
{
    public class RepositorioBase  
    {
        protected DBContext.Context Db = new DBContext.Context(); 
    }
}
