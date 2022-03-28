using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelEmpresas
    {
        private int _id;
        private string _cpf_cnpj;
        private string _inscricao_estadual;
        private string _inscricao_municipal;
        private string _razao_social;
        private string _nome_fantasia;
        private string _endereco;
        private string _numero;
        private string _complemento;
        private string _bairro;
        private int _id_cidade;
        private string _cep;
        private string _email;
        private string _telefone;
        private string _cor;

        public ModelEmpresas()
        {
            Id = 0;
            Cpf_cnpj = "";
            Inscricao_estadual = "";
            Inscricao_municipal = "";
            Razao_social = "";
            Nome_fantasia = "";
            Endereco = "";
            Numero = "";
            Complemento = "";
            Bairro = "";
            Id_cidade = 0;
            Cep = "";
            Email = "";
            Telefone = "";
            Cor = "";
        }

        public ModelEmpresas(int id, string cpf_cnpj, string inscricao_estadual, string inscricao_municipal, string razao_social, string nome_fantasia, string endereco, string numero, string complemento, string bairro, int id__cidade, string cep, string email, string telefone, string cor)
        {
            Id = id;
            Cpf_cnpj = cpf_cnpj;
            Inscricao_estadual = inscricao_estadual;
            Inscricao_municipal = inscricao_municipal;
            Razao_social = razao_social;
            Nome_fantasia = nome_fantasia;
            Endereco = endereco;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Id_cidade = id__cidade;
            Cep = cep;
            Email = email;
            Telefone = telefone;
            Cor = cor;
        }

        public int Id { get => _id; set => _id = value; }
        public string Cpf_cnpj { get => _cpf_cnpj; set => _cpf_cnpj = value; }
        public string Inscricao_estadual { get => _inscricao_estadual; set => _inscricao_estadual = value; }
        public string Inscricao_municipal { get => _inscricao_municipal; set => _inscricao_municipal = value; }
        public string Razao_social { get => _razao_social; set => _razao_social = value; }
        public string Nome_fantasia { get => _nome_fantasia; set => _nome_fantasia = value; }
        public string Endereco { get => _endereco; set => _endereco = value; }
        public string Numero { get => _numero; set => _numero = value; }
        public string Complemento { get => _complemento; set => _complemento = value; }
        public string Bairro { get => _bairro; set => _bairro = value; }
        public int Id_cidade { get => _id_cidade; set => _id_cidade = value; }
        public string Cep { get => _cep; set => _cep = value; }
        public string Email { get => _email; set => _email = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Cor { get => _cor; set => _cor = value; }
    }
}
