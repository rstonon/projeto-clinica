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
    public class BLLDocumentos
    {
        private readonly DALConexao conn;

        public BLLDocumentos(DALConexao conexao)
        {
            this.conn = conexao;
        }
        public void Adicionar(ModelDocumentos obj)
        {
            if (obj.Descricao.Trim().Length.Equals(0))
            {
                throw new Exception("A Descrição é obrigatória!");
            }

            DALDocumentos d = new DALDocumentos(conn);
            d.Adicionar(obj);
        }

        public void Editar(ModelDocumentos obj)
        {
            if (obj.Id <= 0)
            {
                throw new Exception("O Código é obrigatório!");
            }
            if (obj.Descricao.Trim().Length.Equals(0))
            {
                throw new Exception("A Descrição é obrigatória!");
            }

            DALDocumentos d = new DALDocumentos(conn);
            d.Editar(obj);
        }

        public void Excluir(int id)
        {
            DALDocumentos d = new DALDocumentos(conn);
            d.Excluir(id);
        }

        public DataTable PesquisaSql(String pesquisa, String status, String valor)
        {
            DALDocumentos d = new DALDocumentos(conn);
            return d.PesquisaSql(pesquisa, status, valor);
        }

        public ModelDocumentos CarregarGrid(int id)
        {
            DALDocumentos d = new DALDocumentos(conn);
            return d.CarregarGrid(id);
        }

        public int VerificaDocumento(String valor)
        {
            DALDocumentos d = new DALDocumentos(conn);
            return d.VerificaDocumento(valor);
        }
    }
}
