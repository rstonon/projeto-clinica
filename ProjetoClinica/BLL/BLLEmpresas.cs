using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLEmpresas
    {
        private readonly DALConexao conn;

        public BLLEmpresas(DALConexao conexao)
        {
            this.conn = conexao;
        }
        public void Adicionar(ModelEmpresas obj)
        {

            if (obj.Razao_social.Trim().Length.Equals(0))
            {
                throw new Exception("A Razão Social é obrigatória!");
            }

            if (obj.Id_cidade <= 0)
            {
                throw new Exception("A Cidade é obrigatória!");
            }

            DALEmpresas d = new DALEmpresas(conn);
            d.Adicionar(obj);
        }

        public void Editar(ModelEmpresas obj)
        {
            if (obj.Id <= 0)
            {
                throw new Exception("O código da Empresa é obrigatório!");
            }

            if (obj.Razao_social.Trim().Length.Equals(0))
            {
                throw new Exception("A Razão Social é obrigatória!");
            }

            if (obj.Id_cidade <= 0)
            {
                throw new Exception("A Cidade é obrigatória!");
            }

            DALEmpresas d = new DALEmpresas(conn);
            d.Editar(obj);
        }

        public void Excluir(int id)
        {
            DALEmpresas d = new DALEmpresas(conn);
            d.Excluir(id);
        }

        public DataTable PesquisaSql(String pesquisa, String valor)
        {
            DALEmpresas d = new DALEmpresas(conn);
            return d.PesquisaSql(pesquisa, valor);
        }

        public ModelEmpresas CarregarGrid(int id)
        {
            DALEmpresas d = new DALEmpresas(conn);
            return d.CarregarGrid(id);
        }
    }
}
