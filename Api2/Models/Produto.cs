using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api2.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal Preco { get; set; }
    }
}