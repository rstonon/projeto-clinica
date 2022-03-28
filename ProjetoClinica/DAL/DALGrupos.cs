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
    public class DALGrupos
    {
        private readonly DALConexao conn;

        public DALGrupos(DALConexao cx)
        {
            this.conn = cx;
        }

        public void Adicionar(ModelGrupos model)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn.ObjetoConexao,
                    CommandText = "INSERT INTO grupos SET status = @status, tipo = @tipo, descricao = @descricao; SELECT @@IDENTITY;",

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

        public void Editar(ModelGrupos model)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn.ObjetoConexao,
                    CommandText = "UPDATE grupos SET status = @status, tipo = @tipo, descricao = @descricao WHERE id = @id;",

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
                    CommandText = "DELETE FROM grupos WHERE id = @id;",

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
                sql = "SELECT * FROM grupos WHERE id = '" + valor + "'";
            }
            if (pesquisa.Equals("Descrição"))
            {
                sql = "SELECT * FROM grupos WHERE descricao like '%" + valor + "%'";
            }

            Pesquisa = sql + stringStatus + stringTipo;


            MySqlDataAdapter da = new MySqlDataAdapter(Pesquisa, conn.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModelGrupos CarregarGrid(int id)
        {
            ModelGrupos model = new ModelGrupos();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn.ObjetoConexao,
                CommandText = "SELECT * FROM grupos WHERE id = @id;"
            };
            cmd.Parameters.AddWithValue("@id", id.ToString());
            conn.Conectar();
            MySqlDataReader dr = cmd.ExecuteReader();
            List<ModelGrupos> lista = new List<ModelGrupos>();
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

        public int VerificaGrupo(String tipo, String valor)
        {
            int r = 0;
            _ = new ModelGrupos();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn.ObjetoConexao,
                CommandText = "SELECT * FROM grupos WHERE tipo = @tipo and descricao = @descricao;"
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
