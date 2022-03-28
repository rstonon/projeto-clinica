using BLL;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmLogin : Form
    {
        string strDSN = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\SistemaClinica\configuracoes.mdb";

        private readonly DALConexao conn;

        public FrmLogin(DALConexao cx)
        {
            this.conn = cx;
        }

        private void PesquisaEmpresa()
        {
            string strSQL = @"SELECT id, codigo, empresa FROM empresas";

            try
            {
                // cria objetos de ADOConnection e ADOCommand
                OleDbConnection myConn = new OleDbConnection(strDSN);
                OleDbDataAdapter myCmd = new OleDbDataAdapter(strSQL, myConn);
                DataTable dt = new DataTable();
                myCmd.Fill(dt);

                myConn.Open();
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "empresa";
                comboBox2.ValueMember = "id";

                myConn.Close();

            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = comboBox1.Text;
                string senha = textBox2.Text;

                int r = 0;

                DALConexao conn = new DALConexao(DadosConexao.StringConexao);
                BLLUsuarios bll = new BLLUsuarios(conn);

                r = bll.Autenticar(usuario, senha);

                if (r > 0)
                {

                    //FrmAguarde splash = new FrmAguarde();
                    //splash.ShowDialog();

                    FrmMenu f = new FrmMenu();
                    ModelUsuarios model = bll.CarregarGrid(r);
                    f.id_usuario = model.Id;
                    //f.id_perfil = model.Id_perfil;
                    f.UsuarioStatusLabel.Text = model.Usuario;

                    //f.id_empresa = model.Id_empresa;

                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou Senha inválidos");
                    textBox2.Clear();
                    textBox2.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            PesquisaEmpresa();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {

            OleDbConnection myConn = new OleDbConnection(strDSN);
            myConn.Open();
            OleDbCommand myCmd = new OleDbCommand("select * from empresas WHERE id = @id;", myConn);
            myCmd.Parameters.AddWithValue("@id", comboBox2.SelectedValue);
            OleDbDataReader dr = myCmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                //Configuracoes.Id = Convert.ToInt32(dr["codigo"]);
                DadosConexao.server = Convert.ToString(dr["servidor"]);
                DadosConexao.database = Convert.ToString(dr["database"]);
                DadosConexao.user = Convert.ToString(dr["user"]);
                DadosConexao.password = Convert.ToString(dr["password"]);
            }
            myConn.Close();



            DadosConexao.port = "3306";

            DALConexao conn = new DALConexao(DadosConexao.StringConexao);
            BLLUsuarios bll = new BLLUsuarios(conn);
            comboBox1.DataSource = bll.PesquisaSql("Usuário", "Ativo", "");
            comboBox1.DisplayMember = "usuario";
            comboBox1.ValueMember = "id";

        }
    }
}
