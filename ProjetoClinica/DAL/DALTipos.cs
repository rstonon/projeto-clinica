using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class DALTipos
    {
        private readonly DALConexao conn;

        public DALTipos(DALConexao cx)
        {
            this.conn = cx;
        }

        public void Adicionar(ModelTipos model)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn.ObjetoConexao,
                    CommandText = "INSERT INTO tipos SET status = @status, tipo = @tipo, descricao = @descricao; SELECT @@IDENTITY;",

                };

                cmd.Parameters.AddWithValue("@status", model.Status);
                cmd.Parameters.AddWithValue("@tipo", model.Tipo);
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

        public void Editar(ModelTipos model)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn.ObjetoConexao,
                    CommandText = "UPDATE tipos SET status = @status, tipo = @tipo, descricao = @descricao WHERE id = @id;",

                };

                cmd.Parameters.AddWithValue("@status", model.Status);
                cmd.Parameters.AddWithValue("@tipo", model.Tipo);
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
                    CommandText = "DELETE FROM tipos WHERE id = @id;",

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

        public DataTable PesquisaSql(String pesquisa, String status, String tipo, String valor)
        {
            DataTable tabela = new DataTable();

            string Pesquisa = "";
            string sql = "";
            string stringStatus = "";
            string stringTipo = "";

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

            if (tipo != "" && tipo != "Todos")
            {
                stringTipo = " and tipo = '" + tipo + "'";
            }

            if (pesquisa.Equals("Código"))
            {
                sql = "SELECT * FROM tipos WHERE id = '" + valor + "'";
            }
            if (pesquisa.Equals("Descrição"))
            {
                sql = "SELECT * FROM tipos WHERE descricao like '%" + valor + "%'";
            }

            Pesquisa = sql + stringStatus + stringTipo;


            MySqlDataAdapter da = new MySqlDataAdapter(Pesquisa, conn.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModelTipos CarregarGrid(int id)
        {
            ModelTipos model = new ModelTipos();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn.ObjetoConexao,
                CommandText = "SELECT * FROM tipos WHERE id = @id;"
            };
            cmd.Parameters.AddWithValue("@id", id.ToString());
            conn.Conectar();
            MySqlDataReader dr = cmd.ExecuteReader();
            List<ModelTipos> lista = new List<ModelTipos>();
            if (dr.HasRows)
            {
                dr.Read();
                model.Id = Convert.ToInt32(dr["id"]);
                model.Status = Convert.ToBoolean(dr["status"]);
                model.Tipo = Convert.ToString(dr["tipo"]);
                model.Descricao = Convert.ToString(dr["descricao"]);
                lista.Add(model);
            }
            conn.Desconectar();
            return model;
        }

        public int VerificaTipo(String tipo, String valor)
        {
            int r = 0;
            _ = new ModelTipos();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn.ObjetoConexao,
                CommandText = "SELECT * FROM tipos WHERE tipo = @tipo and descricao = @descricao;"
            };
            cmd.Parameters.AddWithValue("@tipo", tipo);
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
