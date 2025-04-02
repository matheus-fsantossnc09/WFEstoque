using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCadastroProduto
{
    public enum EStatus
    {
        Ativo = 1,
        Inativo = 0
    }

    internal class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        public decimal Preco { get; set; }

        public int Quantidade { get; set; }

        public EStatus Status { get; set; }

        public static List<Produto> ListaProdutos = new List<Produto>(); 
    }
}
