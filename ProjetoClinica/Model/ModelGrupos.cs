using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelGrupos
    {
        private int _id;
        private bool _status;
        private string _tipo;
        private string _descricao;

        public ModelGrupos()
        {
            Id = 0;
            Status = true;
            Tipo = "";
            Descricao = "";
        }

        public ModelGrupos(int id, bool status, string tipo, string descricao)
        {
            Id = id;
            Status = status;
            Tipo = tipo;
            Descricao = descricao;
        }

        public int Id { get => _id; set => _id = value; }
        public bool Status { get => _status; set => _status = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
    }
}
