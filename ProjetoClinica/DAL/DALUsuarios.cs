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
    public class DALUsuarios
    {
        private readonly DALConexao conn;

        public DALUsuarios(DALConexao cx)
        {
            this.conn = cx;
        }

        public void Adicionar(ModelUsuarios model)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn.ObjetoConexao,
                    CommandText = "INSERT INTO usuarios SET id_perfil = @id_perfil, status = @status, usuario = @usuario, senha = @senha; SELECT @@IDENTITY;",

                };

                cmd.Parameters.AddWithValue("@id_perfil", model.Id_perfil);
                cmd.Parameters.AddWithValue("@status", model.Status);
                cmd.Parameters.AddWithValue("@usuario", model.Usuario);
                cmd.Parameters.AddWithValue("@senha", model.Senha);
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

        public void Editar(ModelUsuarios model)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn.ObjetoConexao,
                    CommandText = "UPDATE usuarios SET id_perfil = @id_perfil, status = @status, usuario = @usuario, senha = @senha WHERE id = @id;",

                };

                cmd.Parameters.AddWithValue("@id_perfil", model.Id_perfil);
                cmd.Parameters.AddWithValue("@status", model.Status);
                cmd.Parameters.AddWithValue("@usuario", model.Usuario);
                cmd.Parameters.AddWithValue("@senha", model.Senha);
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
                    CommandText = "DELETE FROM usuarios WHERE id = @id;",

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
                sql = "SELECT id, usuario FROM usuarios WHERE id = '" + valor + "'";
            }
            if (pesquisa.Equals("Usuário"))
            {
                sql = "SELECT id, usuario FROM usuarios WHERE usuario like '%" + valor + "%'";
            }

            Pesquisa = sql + stringStatus;


            MySqlDataAdapter da = new MySqlDataAdapter(Pesquisa, conn.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModelUsuarios CarregarGrid(int id)
        {
            ModelUsuarios model = new ModelUsuarios();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn.ObjetoConexao,
                CommandText = "SELECT * FROM usuarios WHERE id = @id;"
            };
            cmd.Parameters.AddWithValue("@id", id.ToString());
            conn.Conectar();
            MySqlDataReader dr = cmd.ExecuteReader();
            List<ModelUsuarios> lista = new List<ModelUsuarios>();
            if (dr.HasRows)
            {
                dr.Read();
                model.Id = Convert.ToInt32(dr["id"]);
                model.Id_perfil = Convert.ToInt32(dr["id_perfil"]);
                model.Status = Convert.ToBoolean(dr["status"]);
                model.Usuario = Convert.ToString(dr["usuario"]);
                model.Senha = Convert.ToString(dr["senha"]);
                lista.Add(model);
            }
            conn.Desconectar();
            return model;
        }

        public int Autenticar(string usuario, string senha)
        {
            try
            {
                int r = 0;
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn.ObjetoConexao,
                    CommandText = "Select id FROM usuarios WHERE usuario = @usuario and senha = @senha;",

                };

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
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
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Desconectar();
            }
        }
    }
}
