using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProdutos.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DBContext.Context db = new DBContext.Context())
            {
                /*
                 * Gravando Dados 
                db.Usuarios.Add(new Entidades.Entidades.Usuario { UsuarioId = 0, ContaUsuario = "admin", Senha = "admin", Perfil = "Admin" });
                db.Usuarios.Add(new Entidades.Entidades.Usuario { UsuarioId = 1, ContaUsuario = "convidado", Senha = "", Perfil = "Convidado" });

                db.SaveChanges();
               */

                //Lendo Dados
                var usuarios = db.Usuarios;

                foreach (var item in usuarios)
                    Console.WriteLine(item.ContaUsuario);

                //Deletando
                //db.Database.Delete();

            }

            Console.WriteLine("\n\nConcluído");
            Console.ReadKey();
        }
    }
}
