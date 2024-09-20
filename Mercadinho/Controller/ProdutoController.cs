using Mercadinho.DAO;
using Mercadinho.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Controller
{
    internal class ProdutoController
    {
        private ProdutoDAO produtoDAO = new ProdutoDAO();

        public List<ProdutoDTO> BuscarProdutos(string nome, string categoria, bool promocao)
		{
			return produtoDAO.ListarProdutos(nome, categoria, promocao);
		}
    }
}
