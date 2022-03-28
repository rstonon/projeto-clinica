using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{

    public static class PermissoesUsuario
    {
        private static int _id_perfil;
        private static bool _tipos_visualizar;
        private static bool _tipos_cadastrar;
        private static bool _tipos_editar;
        private static bool _tipos_excluir;
        private static bool _tipos_relatorios;

        public static int Id_perfil { get => _id_perfil; set => _id_perfil = value; }
        public static bool Tipos_visualizar { get => _tipos_visualizar; set => _tipos_visualizar = value; }
        public static bool Tipos_cadastrar { get => _tipos_cadastrar; set => _tipos_cadastrar = value; }
        public static bool Tipos_editar { get => _tipos_editar; set => _tipos_editar = value; }
        public static bool Tipos_excluir { get => _tipos_excluir; set => _tipos_excluir = value; }
        public static bool Tipos_relatorios { get => _tipos_relatorios; set => _tipos_relatorios = value; }
    }
}
