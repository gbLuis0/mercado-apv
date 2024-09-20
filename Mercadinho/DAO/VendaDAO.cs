using Mercadinho.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Mercadinho.Util;

namespace Mercadinho.DAO
{
    internal class VendaDAO
    {
        // tirei o "private"
        MySqlConnection con;
        MySqlCommand? cmd;
        string? comandosql;

        public VendaDAO()
        {
            ConexaoBD conexaobd = new ConexaoBD();
            con = conexaobd.RetornaConexao();
        }

        public int RegistrarVenda(VendaDTO vendaDTO)
        {
            con.Open();

            comandosql = @"
            INSERT INTO vendas (nomeProduto, codigoProduto, quantidade, metodoPagamento) 
            VALUES 
            (@nomeProduto, @codigoProduto, @quantidade, @metodoPagamento)";

            cmd = new MySqlCommand();
            cmd.CommandText = comandosql;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@nomeProduto", vendaDTO.NomeProduto);
            cmd.Parameters.AddWithValue("@codigoProduto", vendaDTO.CodigoProduto);
            cmd.Parameters.AddWithValue("@quantidade", vendaDTO.Quantidade);
            cmd.Parameters.AddWithValue("@metodoPagamento", vendaDTO.MetodoPagamento);
            cmd.Prepare();

            int resultadosql = cmd.ExecuteNonQuery();
            return resultadosql;
        }
    }
}
