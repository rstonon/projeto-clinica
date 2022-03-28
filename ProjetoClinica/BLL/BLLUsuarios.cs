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
    public class BLLUsuarios
    {
        private readonly DALConexao conn;

        public BLLUsuarios(DALConexao conexao)
        {
            this.conn = conexao;
        }
        public void Adicionar(ModelUsuarios obj)
        {
            if (obj.Usuario.Trim().Length.Equals(0))
            {
                throw new Exception("O Usuário é obrigatório!");
            }
            if (obj.Senha.Trim().Length.Equals(0))
            {
                throw new Exception("A Senha é obrigatória!");
            }
            if (obj.Id_perfil <= 0)
            {
                throw new Exception("O Perfil do Usuário é obrigatório!");
            }

            DALUsuarios d = new DALUsuarios(conn);
            d.Adicionar(obj);
        }

        public void Editar(ModelUsuarios obj)
        {
            if (obj.Id <= 0)
            {
                throw new Exception("O código do usuário é obrigatório!");
            }
            if (obj.Id_perfil <= 0)
            {
                throw new Exception("O Perfil do Usuário é obrigatório!");
            }
            if (obj.Usuario.Trim().Length.Equals(0))
            {
                throw new Exception("O Usuário é obrigatório!");
            }
            if (obj.Senha.Trim().Length.Equals(0))
            {
                throw new Exception("A Senha é obrigatória!");
            }

            DALUsuarios d = new DALUsuarios(conn);
            d.Editar(obj);
        }

        public void Excluir(int id)
        {
            DALUsuarios d = new DALUsuarios(conn);
            d.Excluir(id);
        }

        public DataTable PesquisaSql(String pesquisa, String status, String valor)
        {
            DALUsuarios d = new DALUsuarios(conn);
            return d.PesquisaSql(pesquisa, status, valor);
        }

        public ModelUsuarios CarregarGrid(int id)
        {
            DALUsuarios d = new DALUsuarios(conn);
            return d.CarregarGrid(id);
        }

        public int Autenticar(string usuario, string senha)
        {
            if (usuario.Trim().Length.Equals(0))
            {
                throw new Exception("O Usuário é obrigatório!");
            }
            if (senha.Trim().Length.Equals(0))
            {
                throw new Exception("A Senha é obrigatória!");
            }

            DALUsuarios d = new DALUsuarios(conn);
            return d.Autenticar(usuario, senha);
        }
    }
}
