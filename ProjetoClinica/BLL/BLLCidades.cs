using DAL;
using Model;
using System;
using System.Data;

namespace BLL
{
    public class BLLCidades
    {
        private readonly DALConexao conn;

        public BLLCidades(DALConexao conexao)
        {
            this.conn = conexao;
        }
        public void Adicionar(ModelCidades obj)
        {
            if (obj.Cidade.Trim().Length.Equals(0))
            {
                throw new Exception("A Cidade é obrigatória!");
            }
            if (obj.Uf.Trim().Length.Equals(0))
            {
                throw new Exception("A UF é obrigatória!");
            }

            DALCidades d = new DALCidades(conn);
            d.Adicionar(obj);
        }

        public void Editar(ModelCidades obj)
        {
            if (obj.Id <= 0)
            {
                throw new Exception("O código da cidade é obrigatório!");
            }
            if (obj.Cidade.Trim().Length.Equals(0))
            {
                throw new Exception("A Cidade é obrigatória!");
            }
            if (obj.Uf.Trim().Length.Equals(0))
            {
                throw new Exception("A UF é obrigatória!");
            }

            DALCidades d = new DALCidades(conn);
            d.Editar(obj);
        }

        public void Excluir(int id)
        {
            DALCidades d = new DALCidades(conn);
            d.Excluir(id);
        }

        public DataTable PesquisaSql(String pesquisa, String status, String valor)
        {
            DALCidades d = new DALCidades(conn);
            return d.PesquisaSql(pesquisa, status, valor);
        }

        public ModelCidades CarregarGrid(int id)
        {
            DALCidades d = new DALCidades(conn);
            return d.CarregarGrid(id);
        }

        public ModelCidades PesquisaCidadesPorNome(string cidade, string uf)
        {
            DALCidades d = new DALCidades(conn);
            return d.PesquisaCidadesPorNome(cidade, uf);
        }

        public int VerificaUnidadeDeMedida(String valor)
        {
            DALCidades d = new DALCidades(conn);
            return d.VerificaCidade(valor);
        }
    }
}
