using Mercadinho.DAO;
using Mercadinho.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Controller
{
    internal class VendaController
    {
        public bool RegistrarVenda(string nomeProduto, string codigoProduto, int quantidade, string metodoPagamento)
        {
            VendaDTO vendaDTO = new VendaDTO(nomeProduto,codigoProduto, quantidade, metodoPagamento);
            VendaDAO vendaDAO = new VendaDAO();
            int resultado = vendaDAO.RegistrarVenda(vendaDTO);

            return resultado > 0;
        }
    }
}
