using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploProdutos.Dominio
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
