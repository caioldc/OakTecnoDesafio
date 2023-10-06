using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OakTecnoProva.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public float ValorProduto { get; set; }
        public Boolean DisponivelPVenda { get; set; }
    }
}

