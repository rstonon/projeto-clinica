using DAL;
using Model;
using System;
using System.Data;

namespace BLL
{
    public class BLLColaboradores
    {
        private readonly DALConexao conn;

        public BLLColaboradores(DALConexao conexao)
        {
            this.conn = conexao;
        }
        public void Adicionar(ModelColaboradores obj)
        {
            if (obj.Id_tipo <= 0)
            {
                throw new Exception("O Tipo do Colaborador é obrigatório!");
            }
            if (obj.Razao_social.Trim().Length.Equals(0))
            {
                throw new Exception("A Razão Social é obrigatória!");
            }
            if (obj.Id_cidade <= 0)
            {
                throw new Exception("A Cidade é obrigatória!");
            }

            DALColaboradores d = new DALColaboradores(conn);
            d.Adicionar(obj);
        }

        public void Editar(ModelColaboradores obj)
        {
            if (obj.Id <= 0)
            {
                throw new Exception("O código da cidade é obrigatório!");
            }
            if (obj.Id_tipo <= 0)
            {
                throw new Exception("O Tipo do Colaborador é obrigatório!");
            }
            if (obj.Razao_social.Trim().Length.Equals(0))
            {
                throw new Exception("A Razão Social é obrigatória!");
            }
            if (obj.Id_cidade <= 0)
            {
                throw new Exception("A Cidade é obrigatória!");
            }

            DALColaboradores d = new DALColaboradores(conn);
            d.Editar(obj);
        }

        public void Excluir(int id)
        {
            DALColaboradores d = new DALColaboradores(conn);
            d.Excluir(id);
        }

        public DataTable PesquisaSql(String pesquisa, String tipo, String status, String valor)
        {
            DALColaboradores d = new DALColaboradores(conn);
            return d.PesquisaSql(pesquisa, tipo, status, valor);
        }

        public ModelColaboradores CarregarGrid(int id)
        {
            DALColaboradores d = new DALColaboradores(conn);
            return d.CarregarGrid(id);
        }

        public int VerificaCPFCNPJ(String valor)
        {
            DALColaboradores d = new DALColaboradores(conn);
            return d.VerificaCPFCNPJ(valor);
        }
    }
}
