﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CrudProdutos.Entidades.Entidades
{
    public class TamanhoProduto
    {
        public int TamanhoProdutoId { get; set; }

        public int ProdutoId { get; set; }

        public int Tamanho { get; set; }
    }
}
