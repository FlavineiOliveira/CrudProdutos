namespace CrudProdutos.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adm : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CorProdutos",
                c => new
                    {
                        CorProdutoId = c.Int(nullable: false, identity: true),
                        ProdutoId = c.Int(nullable: false),
                        Cor = c.String(),
                    })
                .PrimaryKey(t => t.CorProdutoId);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                        Foto = c.String(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Data = c.DateTime(nullable: false),
                        TamanhoProdutoId = c.Int(nullable: false),
                        CorProdutoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoId);
            
            CreateTable(
                "dbo.TamanhoProdutos",
                c => new
                    {
                        TamanhoProdutoId = c.Int(nullable: false, identity: true),
                        ProdutoId = c.Int(nullable: false),
                        Tamanho = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TamanhoProdutoId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        ContaUsuario = c.String(),
                        Senha = c.String(),
                        Perfil = c.String(),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.TamanhoProdutos");
            DropTable("dbo.Produtos");
            DropTable("dbo.CorProdutos");
        }
    }
}
