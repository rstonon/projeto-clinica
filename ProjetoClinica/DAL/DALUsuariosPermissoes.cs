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
    public class DALUsuariosPermissoes
    {
        private readonly DALConexao conn;

        public DALUsuariosPermissoes(DALConexao cx)
        {
            this.conn = cx;
        }

        public void Adicionar(ModelUsuariosPermissoes model)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn.ObjetoConexao,
                    CommandText = "INSERT INTO usuario_permissoes SET id_usuario = @id_usuario, tipos_visualizar = @tiposvisualizar, tipos_cadastrar = @tiposcadastrar, " +
                    "tipos_editar = @tiposeditar, tipos_excluir = @tiposexcluir, tipos_relatorios = @tiposrelatorios; SELECT @@IDENTITY;",

                };

                cmd.Parameters.AddWithValue("@id_usuario", model.IdUsuario);
                cmd.Parameters.AddWithValue("@tiposvisualizar", model.TiposVisualizar);
                cmd.Parameters.AddWithValue("@tiposcadastrar", model.TiposCadastrar);
                cmd.Parameters.AddWithValue("@tiposeditar", model.TiposEditar);
                cmd.Parameters.AddWithValue("@tiposexcluir", model.TiposExcluir);
                cmd.Parameters.AddWithValue("@tiposrelatorios", model.TiposRelatorios);
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

        public void Editar(ModelUsuariosPermissoes model)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn.ObjetoConexao,
                    CommandText = "UPDATE usuario_permissoes SET id_usuario = @id_usuario, tipos_visualizar = @tiposvisualizar, tipos_cadastrar = @tiposcadastrar, " +
                    "tipos_editar = @tiposeditar, tipos_excluir = @tiposexcluir, tipos_relatorios = @tiposrelatorios WHERE id = @id;",

                };

                cmd.Parameters.AddWithValue("@id_usuario", model.IdUsuario);
                cmd.Parameters.AddWithValue("@tiposvisualizar", model.TiposVisualizar);
                cmd.Parameters.AddWithValue("@tiposcadastrar", model.TiposCadastrar);
                cmd.Parameters.AddWithValue("@tiposeditar", model.TiposEditar);
                cmd.Parameters.AddWithValue("@tiposexcluir", model.TiposExcluir);
                cmd.Parameters.AddWithValue("@tiposrelatorios", model.TiposRelatorios);
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
                    CommandText = "DELETE FROM usuario_permissoes WHERE id = @id;",
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
                sql = "SELECT id, descricao FROM usuario_permissoes WHERE id = '" + valor + "'";
            }
            if (pesquisa.Equals("Descrição"))
            {
                sql = "SELECT id, descricao FROM usuario_permissoes WHERE descricao like '%" + valor + "%'";
            }

            Pesquisa = sql;


            MySqlDataAdapter da = new MySqlDataAdapter(Pesquisa, conn.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModelUsuariosPermissoes CarregarGrid(int id)
        {
            ModelUsuariosPermissoes model = new ModelUsuariosPermissoes();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn.ObjetoConexao,
                CommandText = "SELECT * FROM perfis_usuarios WHERE id = @id;"
            };
            cmd.Parameters.AddWithValue("@id", id.ToString());
            conn.Conectar();
            MySqlDataReader dr = cmd.ExecuteReader();
            List<ModelUsuariosPermissoes> lista = new List<ModelUsuariosPermissoes>();
            if (dr.HasRows)
            {
                dr.Read();
                model.Id = Convert.ToInt32(dr["id"]);
                model.Descricao = Convert.ToString(dr["descricao"]);
                model.TiposVisualizar = Convert.ToBoolean(dr["tipos_visualizar"]);
                model.TiposCadastrar = Convert.ToBoolean(dr["tipos_cadastrar"]);
                model.TiposEditar = Convert.ToBoolean(dr["tipos_editar"]);
                model.TiposExcluir = Convert.ToBoolean(dr["tipos_excluir"]);
                model.TiposRelatorios = Convert.ToBoolean(dr["tipos_relatorios"]);
                lista.Add(model);
            }
            conn.Desconectar();
            return model;
        }

        public int VerificaPerfil(String descricao)
        {
            int r = 0;
            _ = new ModelUsuariosPermissoes();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn.ObjetoConexao,
                CommandText = "SELECT * FROM perfis_usuarios WHERE descricao = @descricao;"
            };
            cmd.Parameters.AddWithValue("@descricao", descricao);
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
