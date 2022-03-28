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
    public class BLLGrupos
    {
        private readonly DALConexao conn;

        public BLLGrupos(DALConexao conexao)
        {
            this.conn = conexao;
        }
        public void Adicionar(ModelGrupos obj)
        {
            if (obj.Tipo.Trim().Length.Equals(0))
            {
                throw new Exception("O Tipo do Grupo é obrigatório!");
            }
            if (obj.Descricao.Trim().Length.Equals(0))
            {
                throw new Exception("A Descrição do Grupo é obrigatória!");
            }

            DALGrupos d = new DALGrupos(conn);
            d.Adicionar(obj);
        }

        public void Editar(ModelGrupos obj)
        {
            if (obj.Id <= 0)
            {
                throw new Exception("O código do tipo é obrigatório!");
            }
            if (obj.Tipo.Trim().Length.Equals(0))
            {
                throw new Exception("O Tipo do Grupo é obrigatório!");
            }
            if (obj.Descricao.Trim().Length.Equals(0))
            {
                throw new Exception("A Descrição do Grupo é obrigatória!");
            }

            DALGrupos d = new DALGrupos(conn);
            d.Editar(obj);
        }

        public void Excluir(int id)
        {
            DALGrupos d = new DALGrupos(conn);
            d.Excluir(id);
        }

        public DataTable PesquisaSql(String pesquisa, String status, String tipo, String valor)
        {
            DALGrupos d = new DALGrupos(conn);
            return d.PesquisaSql(pesquisa, status, tipo, valor);
        }

        public ModelGrupos CarregarGrid(int id)
        {
            DALGrupos d = new DALGrupos(conn);
            return d.CarregarGrid(id);
        }

        public int VerificaGrupo(String tipo, String valor)
        {
            DALGrupos d = new DALGrupos(conn);
            return d.VerificaGrupo(tipo, valor);
        }
    }
}
