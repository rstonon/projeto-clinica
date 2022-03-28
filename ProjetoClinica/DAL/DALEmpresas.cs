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
    public class DALEmpresas
    {
        private readonly DALConexao conn;

        public DALEmpresas(DALConexao cx)
        {
            this.conn = cx;
        }

        public void Adicionar(ModelEmpresas model)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn.ObjetoConexao,
                    CommandText = "INSERT INTO empresas SET cpf_cnpj = @cpf_cnpj, inscricao_estadual = @inscricao_estadual, inscricao_municipal = @inscricao_municipal, razao_social = @razao_social," +
                    " nome_fantasia = @nome_fantasia, endereco = @endereco, numero = @numero, complemento = @complemento, bairro = @bairro, id_cidade = @id_cidade, cep = @cep, email = @email, telefone = @telefone, cor = @cor; SELECT @@IDENTITY;",
                };

                cmd.Parameters.AddWithValue("@cpf_cnpj", model.Cpf_cnpj);
                cmd.Parameters.AddWithValue("@inscricao_estadual", model.Inscricao_estadual);
                cmd.Parameters.AddWithValue("@inscricao_municipal", model.Inscricao_municipal);
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
                cmd.Parameters.AddWithValue("@cor", model.Cor);
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

        public void Editar(ModelEmpresas model)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn.ObjetoConexao,
                    CommandText = "UPDATE empresas SET cpf_cnpj = @cpf_cnpj, inscricao_estadual = @inscricao_estadual, inscricao_municipal = @inscricao_municipal, razao_social = @razao_social," +
                    " nome_fantasia = @nome_fantasia, endereco = @endereco, numero = @numero, complemento = @complemento, bairro = @bairro, id_cidade = @id_cidade, cep = @cep, email = @email, telefone = @telefone, cor = @cor WHERE id = @id;",

                };

                cmd.Parameters.AddWithValue("@cpf_cnpj", model.Cpf_cnpj);
                cmd.Parameters.AddWithValue("@inscricao_estadual", model.Inscricao_estadual);
                cmd.Parameters.AddWithValue("@inscricao_municipal", model.Inscricao_municipal);
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
                cmd.Parameters.AddWithValue("@cor", model.Cor);
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
                    CommandText = "DELETE FROM empresas WHERE id = @id;",

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

            string criterio = "";

            sql = "SELECT c.id, c.razao_social, c.nome_fantasia, c.telefone, ci.cidade, ci.uf FROM empresas c LEFT JOIN cidades ci on (c.id_cidade = ci.id)";

            if (pesquisa.Equals("Código"))
            {
                criterio = " WHERE c.id = '" + valor + "'";
            }

            if (pesquisa.Equals("Razão Social"))
            {
                if (valor != "")
                {
                    criterio = " where (c.razao_social like '%" + valor + "%' or c.nome_fantasia like '%" + valor + "%'";
                }
            }

            Pesquisa = sql + criterio;

            MySqlDataAdapter da = new MySqlDataAdapter(Pesquisa, conn.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModelEmpresas CarregarGrid(int id)
        {
            ModelEmpresas model = new ModelEmpresas();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn.ObjetoConexao,
                CommandText = "SELECT * FROM empresas WHERE id = @id;"
            };
            cmd.Parameters.AddWithValue("@id", id.ToString());
            conn.Conectar();
            MySqlDataReader dr = cmd.ExecuteReader();
            List<ModelEmpresas> lista = new List<ModelEmpresas>();
            if (dr.HasRows)
            {
                dr.Read();
                model.Id = Convert.ToInt32(dr["id"]);
                model.Cpf_cnpj = Convert.ToString(dr["cpf_cnpj"]);
                model.Inscricao_estadual = Convert.ToString(dr["inscricao_estadual"]);
                model.Inscricao_municipal = Convert.ToString(dr["inscricao_municipal"]);
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
                model.Cor = Convert.ToString(dr["cor"]);
                lista.Add(model);
            }
            conn.Desconectar();
            return model;
        }
    }
}
