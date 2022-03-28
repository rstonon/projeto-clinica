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
    public class BLLUnidadesMedida
    {
        private readonly DALConexao conn;

        public BLLUnidadesMedida(DALConexao conexao)
        {
            this.conn = conexao;
        }
        public void Adicionar(ModelUnidadesMedida obj)
        {
            if (obj.Sigla.Trim().Length.Equals(0))
            {
                throw new Exception("A Sigla é obrigatória!");
            }

            DALUnidadesMedida d = new DALUnidadesMedida(conn);
            d.Adicionar(obj);
        }

        public void Editar(ModelUnidadesMedida obj)
        {
            if (obj.Id <= 0)
            {
                throw new Exception("O código do tipo é obrigatório!");
            }
            if (obj.Sigla.Trim().Length.Equals(0))
            {
                throw new Exception("A Sigla é obrigatória!");
            }

            DALUnidadesMedida d = new DALUnidadesMedida(conn);
            d.Editar(obj);
        }

        public void Excluir(int id)
        {
            DALUnidadesMedida d = new DALUnidadesMedida(conn);
            d.Excluir(id);
        }

        public DataTable PesquisaSql(String pesquisa, String valor)
        {
            DALUnidadesMedida d = new DALUnidadesMedida(conn);
            return d.PesquisaSql(pesquisa, valor);
        }

        public ModelUnidadesMedida CarregarGrid(int id)
        {
            DALUnidadesMedida d = new DALUnidadesMedida(conn);
            return d.CarregarGrid(id);
        }

        public int VerificaUnidadeMedida(String sigla)
        {
            DALUnidadesMedida d = new DALUnidadesMedida(conn);
            return d.VerificaUnidadeMedida(sigla);
        }
    }
}
