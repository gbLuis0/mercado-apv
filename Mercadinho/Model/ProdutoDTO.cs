using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Model
{
    internal class ProdutoDTO
    {
        private string? nome;
        private string? categoria;
        private double preco;
        private bool promocao;
		private int id;

        public ProdutoDTO()
        {
        }

		public ProdutoDTO(int id, string nome, string categoria, bool promocao, double preco)
		{
			this.id = id;
			this.nome = nome;
			this.categoria = categoria;
			this.promocao = promocao;
			this.preco = preco;
		}
		public ProdutoDTO(string nome, string categoria, bool promocao)
		{
			this.nome = nome;
			this.categoria = categoria;
			this.promocao = promocao;
		}

		public string Nome { get => nome; set => nome = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public double Preco { get => preco; set => preco = value; }
        public bool Promocao { get => promocao; set => promocao = value; }
		public int Id { get => id; set => id = value; }

	}
}

