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
    public class BLLPerfisUsuarios
    {
        private readonly DALConexao conn;

        public BLLPerfisUsuarios(DALConexao conexao)
        {
            this.conn = conexao;
        }

        public void Adicionar(ModelUsuariosPermissoes obj)
        {
            if (obj.Descricao.Trim().Length.Equals(0))
            {
                throw new Exception("A Descrição é obrigatória!");
            }

            DALUsuariosPermissoes d = new DALUsuariosPermissoes(conn);
            d.Adicionar(obj);
        }

        public void Editar(ModelUsuariosPermissoes obj)
        {
            if (obj.Id <= 0)
            {
                throw new Exception("O código do tipo é obrigatório!");
            }
            if (obj.Descricao.Trim().Length.Equals(0))
            {
                throw new Exception("A Descrição é obrigatória!");
            }

            DALUsuariosPermissoes d = new DALUsuariosPermissoes(conn);
            d.Editar(obj);
        }

        public void Excluir(int id)
        {
            DALUsuariosPermissoes d = new DALUsuariosPermissoes(conn);
            d.Excluir(id);
        }

        public DataTable PesquisaSql(String pesquisa, String valor)
        {
            DALUsuariosPermissoes d = new DALUsuariosPermissoes(conn);
            return d.PesquisaSql(pesquisa, valor);
        }

        public ModelUsuariosPermissoes CarregarGrid(int id)
        {
            DALUsuariosPermissoes d = new DALUsuariosPermissoes(conn);
            return d.CarregarGrid(id);
        }

        public int VerificaTipo(String descricao)
        {
            DALUsuariosPermissoes d = new DALUsuariosPermissoes(conn);
            return d.VerificaPerfil(descricao);
        }
    }
}
