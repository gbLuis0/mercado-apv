using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Mercadinho.Util
{
	internal class ConexaoBD
	{
		MySqlConnection con;

		public ConexaoBD()
		{
			string strconexao;

			strconexao = "server=localhost;userid=root;password=;database=mercadoapv";
			con = new MySqlConnection(strconexao);
		}

		public MySqlConnection RetornaConexao()
		{
			return con;
		}
	}
}
