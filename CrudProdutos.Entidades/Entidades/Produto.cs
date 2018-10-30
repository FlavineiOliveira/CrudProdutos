using System;
using System.Collections.Generic;
using System.Text;

namespace CrudProdutos.Entidades.Entidades
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Foto { get; set; }

        public decimal Preco { get; set; }

        public DateTime Data { get; set; }

        public int TamanhoProdutoId { get; set; }

        public int CorProdutoId { get; set; }
    }
}
