﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CrudProdutos.Entidades.Entidades
{
    public class CorProduto
    {
        public int CorProdutoId { get; set; }

        public int ProdutoId { get; set; }

        public string Cor { get; set; }
    }
}
