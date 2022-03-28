using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelUsuariosPermissoes
    {
        private int _id;
        private int _id_usuario;
        private bool _tiposVisualizar;
        private bool _tiposCadastrar;
        private bool _tiposEditar;
        private bool _tiposExcluir;
        private bool _tiposRelatorios;

        public ModelUsuariosPermissoes()
        {
            Id = 0;
            IdUsuario = 0;
            TiposVisualizar = false;
            TiposCadastrar = false;
            TiposEditar = false;
            TiposExcluir = false;
            TiposRelatorios = false;
        }

        public ModelUsuariosPermissoes(int id, int idUsuario, bool tiposVisualizar, bool tiposCadastrar, bool tiposEditar, bool tiposExcluir, bool tiposRelatorios)
        {
            Id = id;
            IdUsuario = idUsuario;
            TiposVisualizar = tiposVisualizar;
            TiposCadastrar = tiposCadastrar;
            TiposEditar = tiposEditar;
            TiposExcluir = tiposExcluir;
            TiposRelatorios = tiposRelatorios;
        }

        public int Id { get => _id; set => _id = value; }
        public int IdUsuario { get => _id_usuario; set => _id_usuario = value; }
        public bool TiposVisualizar { get => _tiposVisualizar; set => _tiposVisualizar = value; }
        public bool TiposCadastrar { get => _tiposCadastrar; set => _tiposCadastrar = value; }
        public bool TiposEditar { get => _tiposEditar; set => _tiposEditar = value; }
        public bool TiposExcluir { get => _tiposExcluir; set => _tiposExcluir = value; }
        public bool TiposRelatorios { get => _tiposRelatorios; set => _tiposRelatorios = value; }
    }
}
