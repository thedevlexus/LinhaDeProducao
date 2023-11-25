using LinhaDeProducao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Produtos : Conexao

    {
        public int id;
        public string nome;
        public int id_empresa;
        public DateTime data_cadastro;


        public List<Produtos> GetListaProdutos()
        {
            List<Produtos> produto = new List<Produtos>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM produtos;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Produtos novoProduto = new Produtos();

                            novoProduto.id = Convert.ToInt32(reader.GetString("id"));
                            novoProduto.nome = reader.GetString("nome");
                            novoProduto.id_empresa = Convert.ToInt32(reader.GetString("id_empresa"));
                            novoProduto.data_cadastro = DateTime.Parse(reader.GetString("data_cadastro"));

                            produto.Add(novoProduto);
                        }

                    }

                }

                CloseConnection();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return produto;
        }
    }
}