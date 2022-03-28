using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelUnidadesMedida
    {
        private int _id;
        private string _sigla;
        private string _unidade;

        public ModelUnidadesMedida()
        {
            Id = 0;
            Sigla = "";
            Unidade = "";
        }

        public ModelUnidadesMedida(int id, string sigla, string unidade)
        {
            Id = id;
            Sigla = sigla;
            Unidade = unidade;
        }

        public int Id { get => _id; set => _id = value; }
        public string Sigla { get => _sigla; set => _sigla = value; }
        public string Unidade { get => _unidade; set => _unidade = value; }
    }
}
