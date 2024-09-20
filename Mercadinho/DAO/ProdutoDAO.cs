using MySqlConnector;
using Mercadinho.Model;
using Mercadinho.Util;



namespace Mercadinho.DAO
{
    internal class ProdutoDAO
    {
        private MySqlConnection con;
        private MySqlCommand? cmd;
        private string? comandosql;

        public ProdutoDAO()
        {
            ConexaoBD conexaobd = new ConexaoBD();
            con = conexaobd.RetornaConexao();
        }

        public List<ProdutoDTO> ListarProdutos(string? nome, string? categoria, bool promocao)
        {
            List<ProdutoDTO> lista = new List<ProdutoDTO>();
            con.Open();
            /*
			comandosql = "SELECT * FROM produtos WHERE (@nome IS NULL OR nome = @nome) " +
						 "AND (@categoria IS NULL OR categoria = @categoria) " +

						 "AND (@promocao = 0 OR promocao = @promocao)";
			*/
            comandosql = "SELECT * FROM produto WHERE nome = @nome " +
						 " AND categoria = @categoria " +
						 " AND promocao = @promocao";

			cmd = new MySqlCommand();
            cmd.CommandText = comandosql;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@nome", string.IsNullOrEmpty(nome) ? (object)DBNull.Value : nome);
            cmd.Parameters.AddWithValue("@categoria", string.IsNullOrEmpty(categoria) ? (object)DBNull.Value : categoria);
            cmd.Parameters.AddWithValue("@promocao", promocao);
            cmd.Prepare();

            MySqlDataReader cursor = cmd.ExecuteReader();
            while (cursor.Read())
            {
                ProdutoDTO produto = new ProdutoDTO
                {
                    Id = cursor.GetInt32("idproduto"),
                    Nome = cursor.GetString("nome"),
                    Categoria = cursor.GetString("categoria"),
                    Promocao = cursor.GetBoolean("promocao"),
					Preco = cursor.GetDouble("preco")
				};
                lista.Add(produto);
            }
            return lista;
        }
        
        // Simulando um banco de dados de produtos
        /*private List<ProdutoDTO> produtos = new List<ProdutoDTO>
        {
            new ProdutoDTO("Arroz", "Alimentos", 20.00, false),
            new ProdutoDTO("Feijão", "Alimentos", 15.00, true),
            new ProdutoDTO("Azeite", "Bebidas", 25.00, true),
            new ProdutoDTO("Sabão", "Limpeza", 10.00, false),
        };*/
        /*
        public List<ProdutoDTO> BuscarProdutos(string nome, string categoria, bool promocao)
        {
            // Filtra os produtos com base no nome, categoria e promoção
            List<ProdutoDTO> produtosFiltrados = new List<ProdutoDTO>();

            foreach (var produto in produtos)
            {
                bool nomeCorresponde = string.IsNullOrEmpty(nome) || produto.Nome.ToLower().Contains(nome.ToLower());
                bool categoriaCorresponde = string.IsNullOrEmpty(categoria) || produto.Categoria == categoria;
                //esta faltando o de preço
                bool promocaoCorresponde = !promocao || produto.Promocao;

                if (nomeCorresponde && categoriaCorresponde && promocaoCorresponde)
                {
                    produtosFiltrados.Add(produto);
                }
            }

            return produtosFiltrados;
        }
        */
    }
}
