namespace Model
{
    public class ModelColaboradores
    {
        private int _id;
        private int _id_tipo;
        private bool _status;
        private string _numero_documento;
        private string _rg;
        private string _inscricao_estadual;
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
        private string _celular;
        private string _imagem;

        public ModelColaboradores()
        {
            Id = 0;
            Id_tipo = 0;
            Status = true;
            Numero_documento = "";
            Rg = "";
            Inscricao_estadual = "";
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
            Celular = "";
            Imagem = "";
        }

        public ModelColaboradores(string imagem, string celular, string telefone, string email, string cep, int id_cidade, string bairro, string complemento, string numero, string endereco, string nome_fantasia, string razao_social, string inscricao_estadual, string rg, string numero_documento, bool status, int id_tipo, int id)
        {
            Id = id;
            Id_tipo = id_tipo;
            Status = status;
            Numero_documento = numero_documento;
            Rg = rg;
            Inscricao_estadual = inscricao_estadual;
            Razao_social = razao_social;
            Nome_fantasia = nome_fantasia;
            Endereco = endereco;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Id_cidade = id_cidade;
            Cep = cep;
            Email = email;
            Telefone = telefone;
            Celular = celular;
            Imagem = imagem;
        }

        public int Id { get => _id; set => _id = value; }
        public int Id_tipo { get => _id_tipo; set => _id_tipo = value; }
        public bool Status { get => _status; set => _status = value; }
        public string Numero_documento { get => _numero_documento; set => _numero_documento = value; }
        public string Rg { get => _rg; set => _rg = value; }
        public string Inscricao_estadual { get => _inscricao_estadual; set => _inscricao_estadual = value; }
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
        public string Celular { get => _celular; set => _celular = value; }
        public string Imagem { get => _imagem; set => _imagem = value; }
    }
}
