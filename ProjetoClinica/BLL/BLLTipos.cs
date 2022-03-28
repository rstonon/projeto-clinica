using DAL;
using Model;
using System;
using System.Data;

namespace BLL
{
    public class BLLTipos
    {
        private readonly DALConexao conn;

        public BLLTipos(DALConexao conexao)
        {
            this.conn = conexao;
        }
        public void Adicionar(ModelTipos obj)
        {
            if (obj.Tipo.Trim().Length.Equals(0))
            {
                throw new Exception("O tipo é obrigatório!");
            }
            if (obj.Descricao.Trim().Length.Equals(0))
            {
                throw new Exception("A Descrição é obrigatória!");
            }

            DALTipos d = new DALTipos(conn);
            d.Adicionar(obj);
        }

        public void Editar(ModelTipos obj)
        {
            if (obj.Id <= 0)
            {
                throw new Exception("O código do tipo é obrigatório!");
            }
            if (obj.Tipo.Trim().Length.Equals(0))
            {
                throw new Exception("O tipo é obrigatório!");
            }
            if (obj.Descricao.Trim().Length.Equals(0))
            {
                throw new Exception("A Descrição é obrigatória!");
            }

            DALTipos d = new DALTipos(conn);
            d.Editar(obj);
        }

        public void Excluir(int id)
        {
            DALTipos d = new DALTipos(conn);
            d.Excluir(id);
        }

        public DataTable PesquisaSql(String pesquisa, String status, String tipo, String valor)
        {
            DALTipos d = new DALTipos(conn);
            return d.PesquisaSql(pesquisa, status, tipo, valor);
        }

        public ModelTipos CarregarGrid(int id)
        {
            DALTipos d = new DALTipos(conn);
            return d.CarregarGrid(id);
        }

        public int VerificaTipo(String tipo, String valor)
        {
            DALTipos d = new DALTipos(conn);
            return d.VerificaTipo(tipo, valor);
        }
    }
}
