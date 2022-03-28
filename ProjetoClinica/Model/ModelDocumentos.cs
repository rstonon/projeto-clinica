using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelDocumentos
    {
        private int _id;
        private bool _status;
        private bool _atendimentos;
        private string _descricao;

        public ModelDocumentos()
        {
            Id = 0;
            Status = true;
            Atendimentos = true;
            Descricao = "";
        }

        public ModelDocumentos(int id, bool status, bool atendimentos, string descricao)
        {
            Id = id;
            Status = status;
            Atendimentos = atendimentos;
            Descricao = descricao;
        }

        public int Id { get => _id; set => _id = value; }
        public bool Status { get => _status; set => _status = value; }
        public bool Atendimentos { get => _atendimentos; set => _atendimentos = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
    }
}
