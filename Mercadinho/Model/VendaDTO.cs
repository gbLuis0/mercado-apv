using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Model
{
    internal class VendaDTO
    {
        private string nomeProduto;
        private string codigoProduto;
        private int quantidade;
        private string metodoPagamento;

        public VendaDTO()
        {
        }

        public VendaDTO(string nomeProduto, string codigoProduto, int quantidade, string metodoPagamento)
        {
            this.nomeProduto = nomeProduto;
            this.codigoProduto = codigoProduto;
            this.quantidade = quantidade;
            this.metodoPagamento = metodoPagamento;
        }

        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public string CodigoProduto { get => codigoProduto; set => codigoProduto = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public string MetodoPagamento { get => metodoPagamento; set => metodoPagamento = value; }
        
    }
}

