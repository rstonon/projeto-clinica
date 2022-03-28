namespace Model
{
    public class ModelCidades
    {
        private int _id;
        private bool _status;
        private string _cidade;
        private string _uf;
        private string _codigo_ibge;

        public ModelCidades()
        {
            Id = 0;
            Status = true;
            Cidade = "";
            Uf = "";
            Codigo_ibge = "";
        }

        public ModelCidades(int id, bool status, string cidade, string uf, string codigo_ibge)
        {
            Id = id;
            Status = status;
            Cidade = cidade;
            Uf = uf;
            Codigo_ibge = codigo_ibge;
        }

        public int Id { get => _id; set => _id = value; }
        public bool Status { get => _status; set => _status = value; }
        public string Cidade { get => _cidade; set => _cidade = value; }
        public string Uf { get => _uf; set => _uf = value; }
        public string Codigo_ibge { get => _codigo_ibge; set => _codigo_ibge = value; }
    }
}
