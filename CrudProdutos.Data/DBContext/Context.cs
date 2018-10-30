namespace CrudProdutos.Data.DBContext
{
    using CrudProdutos.Entidades.Entidades;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {
        // Your context has been configured to use a 'Context' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CrudProdutos.Data.DBContext.Context' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Context' 
        // connection string in the application configuration file.
        public Context() : base("name=Context")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<CorProduto> CorProduto { get; set; }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<TamanhoProduto> TamanhoProduto { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}