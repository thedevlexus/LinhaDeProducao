using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinhaDeProducao;
using System.Threading.Tasks;

namespace Listas
{
    internal class Linha_Producao : Conexao
    {
        public int id;
        public int id_empresa;
        public string nome;
        public int id_responsavel;
        public int id_setor;
        public DateTime data_cadastro;

        public List<Linha_Producao> GetListaProducao()
        {
            List<Linha_Producao> linhaP = new List<Linha_Producao>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM linha_producao;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Linha_Producao novalinhaP = new Linha_Producao();

                            novalinhaP.id = Convert.ToInt32(reader.GetString("id"));
                            novalinhaP.nome = reader.GetString("nome");
                            novalinhaP.id_empresa = Convert.ToInt32(reader.GetString("id_empresa"));
                            novalinhaP.id_setor = Convert.ToInt32(reader.GetString("id_setor"));
                            novalinhaP.id_responsavel = Convert.ToInt32(reader.GetString("id_responsavel"));
                            novalinhaP.data_cadastro = DateTime.Parse(reader.GetString("data_cadastro"));

                            linhaP.Add(novalinhaP);
                        }

                    }

                }

                CloseConnection();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return linhaP;
        }
        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `linha_producao` (`nome`,`id_empresa`, `id_setor`, `id_responsavel`) VALUES (@nome, @id_empresa, @id_setor, @id_responsavel);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@id_empresa", this.id_empresa),
                new MySqlParameter("@id_setor", this.id_setor),
                new MySqlParameter("@id_responsavel", this.id_responsavel),
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
