using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class DALCidades
    {
        private readonly DALConexao conn;

        public DALCidades(DALConexao cx)
        {
            this.conn = cx;
        }

        public void Adicionar(ModelCidades model)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn.ObjetoConexao,
                    CommandText = "INSERT INTO cidades SET status = @status, cidade = @cidade, uf = @uf, codigo_ibge = @codigo_ibge; SELECT @@IDENTITY;",
                };

                cmd.Parameters.AddWithValue("@status", model.Status);
                cmd.Parameters.AddWithValue("@cidade", model.Cidade);
                cmd.Parameters.AddWithValue("@uf", model.Uf);
                cmd.Parameters.AddWithValue("@codigo_ibge", model.Codigo_ibge);
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

        public void Editar(ModelCidades model)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn.ObjetoConexao,
                    CommandText = "UPDATE cidades SET status = @status, cidade = @cidade, uf = @uf, codigo_ibge = @codigo_ibge WHERE id = @id;",

                };

                cmd.Parameters.AddWithValue("@status", model.Status);
                cmd.Parameters.AddWithValue("@cidade", model.Cidade);
                cmd.Parameters.AddWithValue("@uf", model.Uf);
                cmd.Parameters.AddWithValue("@codigo_ibge", model.Codigo_ibge);
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
                    CommandText = "DELETE FROM cidades WHERE id = @id;",

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
                sql = "SELECT * FROM cidades WHERE id = '" + valor + "'";
            }
            if (pesquisa.Equals("Cidade"))
            {
                sql = "SELECT * FROM cidades WHERE cidade like '%" + valor + "%'";
            }

            Pesquisa = sql + stringStatus;


            MySqlDataAdapter da = new MySqlDataAdapter(Pesquisa, conn.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModelCidades CarregarGrid(int id)
        {
            ModelCidades model = new ModelCidades();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn.ObjetoConexao,
                CommandText = "SELECT * FROM cidades WHERE id = @id;"
            };
            cmd.Parameters.AddWithValue("@id", id.ToString());
            conn.Conectar();
            MySqlDataReader dr = cmd.ExecuteReader();
            List<ModelCidades> lista = new List<ModelCidades>();
            if (dr.HasRows)
            {
                dr.Read();
                model.Id = Convert.ToInt32(dr["id"]);
                model.Status = Convert.ToBoolean(dr["status"]);
                model.Cidade = Convert.ToString(dr["cidade"]);
                model.Uf = Convert.ToString(dr["uf"]);
                model.Codigo_ibge = Convert.ToString(dr["codigo_ibge"]);
                lista.Add(model);
            }
            conn.Desconectar();
            return model;
        }

        public ModelCidades PesquisaCidadesPorNome(string cidade, string uf)
        {
            ModelCidades model = new ModelCidades();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn.ObjetoConexao,
                CommandText = "SELECT * FROM cidades WHERE cidade = @cidade and uf = @uf;"
            };
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@uf", uf);
            conn.Conectar();
            MySqlDataReader dr = cmd.ExecuteReader();
            List<ModelCidades> lista = new List<ModelCidades>();
            if (dr.HasRows)
            {
                dr.Read();
                model.Id = Convert.ToInt32(dr["id"]);
                lista.Add(model);
            }
            conn.Desconectar();
            return model;
        }

        public int VerificaCidade(string valor)
        {
            int r = 0;
            _ = new ModelCidades();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn.ObjetoConexao,
                CommandText = "SELECT * FROM cidades WHERE cidade = @cidade;"
            };
            cmd.Parameters.AddWithValue("@cidade", valor);
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
