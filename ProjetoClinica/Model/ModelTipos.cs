namespace Model
{
    public class ModelTipos
    {
        private int _id;
        private bool _status;
        private string _tipo;
        private string _descricao;

        public ModelTipos()
        {
            Id = 0;
            Status = true;
            Tipo = "";
            Descricao = "";
        }

        public ModelTipos(int id, string tipo, bool status, string descricao)
        {
            Id = id;
            Tipo = tipo;
            Status = status;
            Descricao = descricao;
        }

        public int Id { get => _id; set => _id = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public bool Status { get => _status; set => _status = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
    }
}
