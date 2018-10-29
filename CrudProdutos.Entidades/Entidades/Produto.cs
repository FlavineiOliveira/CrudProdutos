﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CrudProdutos.Entidades.Entidades
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Foto { get; set; }

        public decimal Preco { get; set; }

        public DateTime Data { get; set; }

        List<TamanhoProduto> TamanhoProduto { get; set; }

        List<CorProduto> CorProduto { get; set; }
    }
}