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
    public class DALDocumentos
    {
        private readonly DALConexao conn;

        public DALDocumentos(DALConexao cx)
        {
            this.conn = cx;
        }

        public void Adicionar(ModelDocumentos model)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn.ObjetoConexao,
                    CommandText = "INSERT INTO documentos SET status = @status, atendimentos = @atendimentos, descricao = @descricao; SELECT @@IDENTITY;",

                };

                cmd.Parameters.AddWithValue("@status", model.Status);
                cmd.Parameters.AddWithValue("@atendimentos", model.Atendimentos);
                cmd.Parameters.AddWithValue("@descricao", model.Descricao);
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

        public void Editar(ModelDocumentos model)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn.ObjetoConexao,
                    CommandText = "UPDATE documentos SET status = @status, atendimentos = @atendimentos, descricao = @descricao WHERE id = @id;",

                };

                cmd.Parameters.AddWithValue("@status", model.Status);
                cmd.Parameters.AddWithValue("@atendimentos", model.Atendimentos);
                cmd.Parameters.AddWithValue("@descricao", model.Descricao);
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
                    CommandText = "DELETE FROM documentos WHERE id = @id;",

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

        public DataTable PesquisaSql(String pesquisa, String status, String valor)
        {
            DataTable tabela = new DataTable();

            string Pesquisa = "";
            string sql = "";
            string stringStatus = "";

            if (status != "" && status != "Todos")
            {
                if (status == "Ativo")
                {
                    status = "1";
                }
                if (status == "Inativo")
                {
                    status = "0";
                }

                stringStatus = " and status = '" + status + "'";

            }

            if (pesquisa.Equals("Código"))
            {
                sql = "SELECT * FROM documentos WHERE id = '" + valor + "'";
            }
            if (pesquisa.Equals("Descrição"))
            {
                sql = "SELECT * FROM documentos WHERE descricao like '%" + valor + "%'";
            }

            Pesquisa = sql + stringStatus;


            MySqlDataAdapter da = new MySqlDataAdapter(Pesquisa, conn.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModelDocumentos CarregarGrid(int id)
        {
            ModelDocumentos model = new ModelDocumentos();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn.ObjetoConexao,
                CommandText = "SELECT * FROM documentos WHERE id = @id;"
            };
            cmd.Parameters.AddWithValue("@id", id.ToString());
            conn.Conectar();
            MySqlDataReader dr = cmd.ExecuteReader();
            List<ModelDocumentos> lista = new List<ModelDocumentos>();
            if (dr.HasRows)
            {
                dr.Read();
                model.Id = Convert.ToInt32(dr["id"]);
                model.Status = Convert.ToBoolean(dr["status"]);
                model.Atendimentos = Convert.ToBoolean(dr["atendimentos"]);
                model.Descricao = Convert.ToString(dr["descricao"]);
                lista.Add(model);
            }
            conn.Desconectar();
            return model;
        }

        public int VerificaDocumento(String valor)
        {
            int r = 0;
            _ = new ModelDocumentos();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn.ObjetoConexao,
                CommandText = "SELECT * FROM documentos WHERE descricao = @descricao;"
            };
            cmd.Parameters.AddWithValue("@descricao", valor);
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
