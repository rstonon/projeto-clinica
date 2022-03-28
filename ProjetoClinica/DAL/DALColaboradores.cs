using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class DALColaboradores
    {
        private readonly DALConexao conn;

        public DALColaboradores(DALConexao cx)
        {
            this.conn = cx;
        }

        public void Adicionar(ModelColaboradores model)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn.ObjetoConexao,
                    CommandText = "INSERT INTO colaboradores SET id_tipo = @id_tipo, status = @status, numero_documento = @numero_documento, rg = @rg, inscricao_estadual = @inscricao_estadual, razao_social = @razao_social," +
                    " nome_fantasia = @nome_fantasia, endereco = @endereco, numero = @numero, complemento = @complemento, bairro = @bairro, id_cidade = @id_cidade, cep = @cep, email = @email, telefone = @telefone, celular = @celular, imagem = @imagem; SELECT @@IDENTITY;",
                };

                cmd.Parameters.AddWithValue("@id_tipo", model.Id_tipo);
                cmd.Parameters.AddWithValue("@status", model.Status);
                cmd.Parameters.AddWithValue("@numero_documento", model.Numero_documento);
                cmd.Parameters.AddWithValue("@rg", model.Rg);
                cmd.Parameters.AddWithValue("@inscricao_estadual", model.Inscricao_estadual);
                cmd.Parameters.AddWithValue("@razao_social", model.Razao_social);
                cmd.Parameters.AddWithValue("@nome_fantasia", model.Nome_fantasia);
                cmd.Parameters.AddWithValue("@endereco", model.Endereco);
                cmd.Parameters.AddWithValue("@numero", model.Numero);
                cmd.Parameters.AddWithValue("@complemento", model.Complemento);
                cmd.Parameters.AddWithValue("@bairro", model.Bairro);
                cmd.Parameters.AddWithValue("@id_cidade", model.Id_cidade);
                cmd.Parameters.AddWithValue("@cep", model.Cep);
                cmd.Parameters.AddWithValue("@email", model.Email);
                cmd.Parameters.AddWithValue("@telefone", model.Telefone);
                cmd.Parameters.AddWithValue("@celular", model.Celular);
                cmd.Parameters.AddWithValue("@imagem", model.Imagem);
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

        public void Editar(ModelColaboradores model)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn.ObjetoConexao,
                    CommandText = "UPDATE colaboradores SET id_tipo = @id_tipo, status = @status, numero_documento = @numero_documento, rg = @rg, inscricao_estadual = @inscricao_estadual, razao_social = @razao_social," +
                    " nome_fantasia = @nome_fantasia, endereco = @endereco, numero = @numero, complemento = @complemento, bairro = @bairro, id_cidade = @id_cidade, cep = @cep, email = @email, telefone = @telefone, celular = @celular, imagem = @imagem WHERE id = @id;",

                };

                cmd.Parameters.AddWithValue("@id_tipo", model.Id_tipo);
                cmd.Parameters.AddWithValue("@status", model.Status);
                cmd.Parameters.AddWithValue("@numero_documento", model.Numero_documento);
                cmd.Parameters.AddWithValue("@rg", model.Rg);
                cmd.Parameters.AddWithValue("@inscricao_estadual", model.Inscricao_estadual);
                cmd.Parameters.AddWithValue("@razao_social", model.Razao_social);
                cmd.Parameters.AddWithValue("@nome_fantasia", model.Nome_fantasia);
                cmd.Parameters.AddWithValue("@endereco", model.Endereco);
                cmd.Parameters.AddWithValue("@numero", model.Numero);
                cmd.Parameters.AddWithValue("@complemento", model.Complemento);
                cmd.Parameters.AddWithValue("@bairro", model.Bairro);
                cmd.Parameters.AddWithValue("@id_cidade", model.Id_cidade);
                cmd.Parameters.AddWithValue("@cep", model.Cep);
                cmd.Parameters.AddWithValue("@email", model.Email);
                cmd.Parameters.AddWithValue("@telefone", model.Telefone);
                cmd.Parameters.AddWithValue("@celular", model.Celular);
                cmd.Parameters.AddWithValue("@imagem", model.Imagem);
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
                    CommandText = "DELETE FROM colaboradores WHERE id = @id;",

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

        public DataTable PesquisaSql(String pesquisa, string tipo, String status, String valor)
        {
            DataTable tabela = new DataTable();

            string Pesquisa = "";
            string sql = "";
            string stringStatus = "";
            string stringTipo = "";

            string criterio = "";

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

                stringStatus = " and c.status = '" + status + "'";

            }


            if (tipo != "" && tipo != "Todos")
            {
                stringTipo = " and t.id = '" + tipo + "'";
            }

            sql = "SELECT c.id, c.razao_social, c.nome_fantasia, c.telefone, c.celular, ci.cidade, ci.uf FROM colaboradores c LEFT JOIN cidades ci on (c.id_cidade = ci.id) LEFT JOIN tipos t on (c.id_tipo = t.id)";

            if (pesquisa.Equals("Código"))
            {
                //sql = "SELECT c.id, c.razao_social, c.nome_fantasia, c.telefone, c.celular, ci.cidade, ci.uf FROM colaboradores c LEFT JOIN cidades ci on (c.id_cidade = ci.id) WHERE c.id = '" + valor + "'";
                criterio = " WHERE c.id = '" + valor + "'";
            }
            if (pesquisa.Equals("Número Documento"))
            {
                //sql = "SELECT c.id, c.razao_social, c.nome_fantasia, c.telefone, c.celular, ci.cidade, ci.uf FROM colaboradores c LEFT JOIN cidades ci on (c.id_cidade = ci.id) WHERE c.numero_documento like '%" + valor + "%'";
                criterio = " WHERE c.numero_documento like '%" + valor + "%'";
            }
            if (pesquisa.Equals("Nome"))
            {
                //sql = "SELECT c.id, c.razao_social, c.nome_fantasia, c.telefone, c.celular, ci.cidade, ci.uf FROM colaboradores c LEFT JOIN cidades ci on (c.id_cidade = ci.id) WHERE (c.razao_social like '%" + valor + "%' or c.nome_fantasia like '%" + valor + "%'";
                if (valor != "")
                {
                    criterio = " where (c.razao_social like '%" + valor + "%' or c.nome_fantasia like '%" + valor + "%'";
                }
            }

            Pesquisa = sql + criterio + stringStatus;


            MySqlDataAdapter da = new MySqlDataAdapter(Pesquisa, conn.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModelColaboradores CarregarGrid(int id)
        {
            ModelColaboradores model = new ModelColaboradores();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn.ObjetoConexao,
                CommandText = "SELECT * FROM colaboradores WHERE id = @id;"
            };
            cmd.Parameters.AddWithValue("@id", id.ToString());
            conn.Conectar();
            MySqlDataReader dr = cmd.ExecuteReader();
            List<ModelColaboradores> lista = new List<ModelColaboradores>();
            if (dr.HasRows)
            {
                dr.Read();
                model.Id = Convert.ToInt32(dr["id"]);
                model.Id_tipo = Convert.ToInt32(dr["id_tipo"]);
                model.Status = Convert.ToBoolean(dr["status"]);
                model.Numero_documento = Convert.ToString(dr["numero_documento"]);
                model.Rg = Convert.ToString(dr["rg"]);
                model.Inscricao_estadual = Convert.ToString(dr["inscricao_estadual"]);
                model.Razao_social = Convert.ToString(dr["razao_social"]);
                model.Nome_fantasia = Convert.ToString(dr["nome_fantasia"]);
                model.Endereco = Convert.ToString(dr["endereco"]);
                model.Numero = Convert.ToString(dr["numero"]);
                model.Complemento = Convert.ToString(dr["complemento"]);
                model.Bairro = Convert.ToString(dr["bairro"]);
                model.Id_cidade = Convert.ToInt32(dr["id_cidade"]);
                model.Cep = Convert.ToString(dr["cep"]);
                model.Email = Convert.ToString(dr["email"]);
                model.Telefone = Convert.ToString(dr["telefone"]);
                model.Celular = Convert.ToString(dr["celular"]);
                model.Imagem = Convert.ToString(dr["imagem"]);
                lista.Add(model);
            }
            conn.Desconectar();
            return model;
        }

        public int VerificaCPFCNPJ(String valor)
        {
            int r = 0;
            _ = new ModelColaboradores();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn.ObjetoConexao,
                CommandText = "SELECT * FROM colaboradores WHERE numero_documento = @numero_documento;"
            };
            cmd.Parameters.AddWithValue("@numero_documento", valor);
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
