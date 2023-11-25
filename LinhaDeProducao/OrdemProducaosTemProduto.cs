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
    internal class OrdemProducaosTemProdutos : Conexao

    {
        public int id;
        public int id_ordem;
        public int id_produto;
        public int quantidade;
        public DateTime data_cadastro;


        public List<OrdemProducaosTemProdutos> GetListaOrdemProducaosTemProdutos()
        {
            List<OrdemProducaosTemProdutos> ordemProducaosTemProduto = new List<OrdemProducaosTemProdutos>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM ordem_producao_tem_produtos;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrdemProducaosTemProdutos novoordemProducaosTemProduto = new OrdemProducaosTemProdutos();

                            novoordemProducaosTemProduto.id = Convert.ToInt32(reader.GetString("id"));
                            novoordemProducaosTemProduto.id_ordem = Convert.ToInt32(reader.GetString("id_empresa"));
                            novoordemProducaosTemProduto.id_produto = Convert.ToInt32(reader.GetString("id_setor"));
                            novoordemProducaosTemProduto.quantidade = Convert.ToInt32(reader.GetString("id_cliente"));
                            novoordemProducaosTemProduto.data_cadastro = DateTime.Parse(reader.GetString("data_cadastro"));

                            ordemProducaosTemProduto.Add(novoordemProducaosTemProduto);
                        }

                    }

                }

                CloseConnection();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return ordemProducaosTemProduto;
        }
        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `ordem_producao_tem_produtos` (`id_ordem`,`id_produto`, `quantidade`) VALUES (@id_ordem, @id_produto, @quantidade);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                 new MySqlParameter("@id_ordem", this.id_ordem),
                 new MySqlParameter("@id_produto", this.id_produto),
                 new MySqlParameter("@quantidade", this.quantidade)
                };

                this.ExecuteQueryWithParameters(query, param);

                return true;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

        }
    }
}