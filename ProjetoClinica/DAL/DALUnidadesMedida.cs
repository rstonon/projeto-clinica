using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALUnidadesMedida
    {
        private readonly DALConexao conn;

        public DALUnidadesMedida(DALConexao cx)
        {
            this.conn = cx;
        }

        public void Adicionar(ModelUnidadesMedida model)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn.ObjetoConexao,
                    CommandText = "INSERT INTO unidades_medida SET sigla = @sigla, unidade = @unidade; SELECT @@IDENTITY;",

                };

                cmd.Parameters.AddWithValue("@sigla", model.Sigla);
                cmd.Parameters.AddWithValue("@unidade", model.Unidade);
                conn.Conectar();
                model.Id = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Desconectar();
            }
        }

        public void Editar(ModelUnidadesMedida model)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn.ObjetoConexao,
                    CommandText = "UPDATE unidades_medida SET sigla = @sigla, unidade = @unidade WHERE id = @id;",

                };

                cmd.Parameters.AddWithValue("@sigla", model.Sigla);
                cmd.Parameters.AddWithValue("@unidade", model.Unidade);
                cmd.Parameters.AddWithValue("@id", model.Id);
                conn.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Desconectar();
            }
        }

        public void Excluir(int codigo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn.ObjetoConexao,
                    CommandText = "DELETE FROM unidades_medida WHERE id = @id;",

                };

                cmd.Parameters.AddWithValue("@id", codigo);
                conn.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Desconectar();
            }
        }

        public DataTable PesquisaSql(String pesquisa, String valor)
        {
            DataTable tabela = new DataTable();

            string Pesquisa = "";
            string sql = "";

            if (pesquisa.Equals("Código"))
            {
                sql = "SELECT * FROM unidades_medida WHERE id = '" + valor + "'";
            }
            if (pesquisa.Equals("Sigla"))
            {
                sql = "SELECT * FROM unidades_medida WHERE sigla like '%" + valor + "%'";
            }
            if (pesquisa.Equals("Unidade"))
            {
                sql = "SELECT * FROM unidades_medida WHERE unidade like '%" + valor + "%'";
            }

            Pesquisa = sql;


            MySqlDataAdapter da = new MySqlDataAdapter(Pesquisa, conn.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModelUnidadesMedida CarregarGrid(int id)
        {
            ModelUnidadesMedida model = new ModelUnidadesMedida();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn.ObjetoConexao,
                CommandText = "SELECT * FROM unidades_medida WHERE id = @id;"
            };
            cmd.Parameters.AddWithValue("@id", id.ToString());
            conn.Conectar();
            MySqlDataReader dr = cmd.ExecuteReader();
            List<ModelUnidadesMedida> lista = new List<ModelUnidadesMedida>();
            if (dr.HasRows)
            {
                dr.Read();
                model.Id = Convert.ToInt32(dr["id"]);
                model.Sigla = Convert.ToString(dr["sigla"]);
                model.Unidade = Convert.ToString(dr["unidade"]);
                lista.Add(model);
            }
            conn.Desconectar();
            return model;
        }

        public int VerificaUnidadeMedida(String sigla)
        {
            int r = 0;
            _ = new ModelTipos();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn.ObjetoConexao,
                CommandText = "SELECT * FROM unidades_medida WHERE sigla = @sigla;"
            };
            cmd.Parameters.AddWithValue("@sigla", sigla);
            conn.Conectar();
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                r = Convert.ToInt32(dr["id"]);
            }
            conn.Desconectar();
            return r;
        }
    }
}
