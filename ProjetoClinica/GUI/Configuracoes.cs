using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Configuracoes
    {
        private static int _id;
        private static string _cpf_cnpj;
        private static string _inscricao_estadual;
        private static string _inscricao_municipal;
        private static string _razao_social;
        private static string _nome_fantasia;
        private static string _endereco;
        private static string _numero;
        private static string _complemento;
        private static string _bairro;
        private static int _id_cidade;
        private static string _cep;
        private static string _email;
        private static string _telefone;
        private static string _cor;

        public static int Id { get => _id; set => _id = value; }
        public static string Cpf_cnpj { get => _cpf_cnpj; set => _cpf_cnpj = value; }
        public static string Inscricao_estadual { get => _inscricao_estadual; set => _inscricao_estadual = value; }
        public static string Inscricao_municipal { get => _inscricao_municipal; set => _inscricao_municipal = value; }
        public static string Razao_social { get => _razao_social; set => _razao_social = value; }
        public static string Nome_fantasia { get => _nome_fantasia; set => _nome_fantasia = value; }
        public static string Endereco { get => _endereco; set => _endereco = value; }
        public static string Numero { get => _numero; set => _numero = value; }
        public static string Complemento { get => _complemento; set => _complemento = value; }
        public static string Bairro { get => _bairro; set => _bairro = value; }
        public static int Id_cidade { get => _id_cidade; set => _id_cidade = value; }
        public static string Cep { get => _cep; set => _cep = value; }
        public static string Email { get => _email; set => _email = value; }
        public static string Telefone { get => _telefone; set => _telefone = value; }
        public static string Cor { get => _cor; set => _cor = value; }
    }
}
