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
    internal class Etapas : Conexao

    {
        public int id;
        public string nome;
        public int ordem;
        public int id_processo;
        public DateTime data_cadastro;


        public List<Etapas> GetListaEtapas()
        {
            List<Etapas> etapa = new List<Etapas>();

            try
            {
                OpenConnection();

                string query = "SELECT * FROM etapas;";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Etapas novoEtapa = new Etapas();

                            novoEtapa.id = Convert.ToInt32(reader.GetString("id"));
                            novoEtapa.nome = reader.GetString("nome");
                            novoEtapa.ordem = Convert.ToInt32(reader.GetString("ordem"));
                            novoEtapa.id_processo = Convert.ToInt32(reader.GetString("id+processo"));
                            novoEtapa.data_cadastro = DateTime.Parse(reader.GetString("data_cadastro"));

                            etapa.Add(novoEtapa);
                        }

                    }

                }

                CloseConnection();
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }

            return etapa;
        }
        public bool Insert()
        {

            try
            {

                string query = "INSERT INTO `etapas` (`nome`, `ordem`, `id_processo`) VALUES (@nome, @ordem, @id_processo);";

                MySqlParameter[] param = new MySqlParameter[]
                {
                new MySqlParameter("@nome", this.nome),
                new MySqlParameter("@ordem", this.ordem),
                new MySqlParameter("@id_processo", this.id_processo)
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
