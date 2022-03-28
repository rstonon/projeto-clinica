using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelUsuarios
    {
        private int _id;
        private int _id_perfil;
        private bool _status;
        private string _usuario;
        private string _senha;

        public ModelUsuarios()
        {
            Id = 0;
            Id_perfil = 0;
            Status = true;
            Usuario = "";
            Senha = "";
        }

        public ModelUsuarios(int id, int id_perfil, bool status, string usuario, string senha)
        {
            Id = id;
            Id_perfil = id_perfil;
            Status = status;
            Usuario = usuario;
            Senha = senha;
        }

        public int Id { get => _id; set => _id = value; }
        public bool Status { get => _status; set => _status = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Senha { get => _senha; set => _senha = value; }
        public int Id_perfil { get => _id_perfil; set => _id_perfil = value; }

        public ModelUsuariosPermissoes usuariosPermissoes { get => usuariosPermissoes; set => usuariosPermissoes = value; }
    }
}
