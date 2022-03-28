using System;

namespace DAL
{
    public class DadosConexao
    {
        public static string server;
        public static string port;
        public static string database;
        public static string user;
        public static string password;

        public static String StringConexao
        {
            get
            {
                //return "Server=127.0.0.1;Port=3306;Database=sistema_clinica;Uid=root;Pwd=m4n5mn45;";
                return "Server=" + server + ";Port=" + port + ";Database=" + database + ";Uid=" + user + ";Pwd=" + password + ";";
            }
        }
    }
}
