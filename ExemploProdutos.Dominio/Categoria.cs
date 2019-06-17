using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploProdutos.Dominio
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
