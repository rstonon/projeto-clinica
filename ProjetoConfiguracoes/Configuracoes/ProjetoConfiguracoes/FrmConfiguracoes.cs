using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProjetoConfiguracoes
{
    public partial class FrmConfiguracoes : Form
    {
        string strDSN = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\SistemaClinica\configuracoes.mdb";
        private string operacao;

        public FrmConfiguracoes()
        {
            InitializeComponent();
        }

        public void AlteraBotoes(int op)
        {
            BtnNovo.Visible = false;
            BtnAbrir.Visible = false;
            BtnExcluir.Visible = false;
            BtnSalvar.Visible = false;
            BtnCancelar.Visible = false;

            if (op == 1)
            {
                BtnNovo.Visible = true;
                BtnAbrir.Visible = true;
                BtnExcluir.Visible = true;
                tbcDados.SelectedTab = tpPesquisa;
            }

            if (op == 2)
            {
                BtnSalvar.Visible = true;
                BtnCancelar.Visible = true;
                tbcDados.SelectedTab = tpDados;
            }
        }

        private void LimparDados()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void Pesquisa()
        {
            string strSQL = @"SELECT id, codigo, empresa FROM empresas";

            try
            {
                // cria objetos de ADOConnection e ADOCommand
                OleDbConnection myConn = new OleDbConnection(strDSN);
                OleDbDataAdapter myCmd = new OleDbDataAdapter(strSQL, myConn);
                myConn.Open();
                DataSet dtSet = new DataSet();
                myCmd.Fill(dtSet, "empresas");
                DataTable dTable = dtSet.Tables[0];
                DgvDados.DataSource = dtSet.Tables["empresas"].DefaultView;
                myConn.Close();

                CarregarGrid();
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmConfiguracoes_Load(object sender, EventArgs e)
        {
            AlteraBotoes(1);

            Pesquisa();

        }

        private void CarregarGrid()
        {
            DgvDados.Columns[0].Visible = false;
            //DgvDados.Columns[0].HeaderText = "ID";
            //DgvDados.Columns[0].Width = 50;
            DgvDados.Columns[1].HeaderText = "Código";
            DgvDados.Columns[1].Width = 50;
            DgvDados.Columns[2].HeaderText = "Empresa";
            DgvDados.Columns[2].Width = 350;
        }

        private void Novo()
        {
            operacao = "Inclusão";
            AlteraBotoes(2);
        }

        private void Abrir()
        {
            if (DgvDados.Rows.Count > 0)
            {
                textBox8.Text = DgvDados.CurrentRow.Cells[0].Value.ToString();
                operacao = "Edição";
                AlteraBotoes(2);

                OleDbConnection myConn = new OleDbConnection(strDSN);
                myConn.Open();
                OleDbCommand myCmd = new OleDbCommand("select * from empresas WHERE id = @id;", myConn);
                myCmd.Parameters.AddWithValue("@id", textBox8.Text);
                OleDbDataReader dr = myCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    textBox1.Text = Convert.ToString(dr["codigo"]);
                    textBox2.Text = Convert.ToString(dr["empresa"]);
                    textBox3.Text = Convert.ToString(dr["servidor"]);
                    textBox4.Text = Convert.ToString(dr["database"]);
                    textBox5.Text = Convert.ToString(dr["user"]);
                    textBox6.Text = Convert.ToString(dr["password"]);
                    textBox7.Text = Convert.ToString(dr["odbc"]);
                }
                myConn.Close();
            }
        }

        private void Salvar()
        {
            if (MessageBox.Show("Deseja salvar os dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (operacao.Equals("Inclusão"))
                {

                    // cria objetos de ADOConnection e ADOCommand
                    OleDbConnection myConn = new OleDbConnection(strDSN);
                    OleDbCommand myCmd = myConn.CreateCommand();

                    myCmd.CommandText = "INSERT INTO empresas ([codigo], [empresa],  [servidor], [database], [user], [password], [odbc]) VALUES (@codigo, @empresa, @servidor, @database, @user, @password, @odbc)";

                    myCmd.Parameters.AddRange(new OleDbParameter[]
           {
               new OleDbParameter("@codigo", textBox1.Text),
               new OleDbParameter("@empresa", textBox2.Text),
               new OleDbParameter("@servidor", textBox3.Text),
               new OleDbParameter("@database", textBox4.Text),
               new OleDbParameter("@user", textBox5.Text),
               new OleDbParameter("@password", textBox6.Text),
               new OleDbParameter("@odbc", textBox7.Text),

           });

                    try
                    {
                        myConn.Open();
                        myCmd.ExecuteNonQuery();
                        myConn.Close();

                        AlteraBotoes(1);
                    }
                    catch (OdbcException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    OleDbConnection myConn = new OleDbConnection(strDSN);
                    OleDbCommand myCmd = myConn.CreateCommand();

                    myCmd.CommandText = "UPDATE empresas SET [codigo] = @codigo, [empresa] = @empresa,  [servidor] = @servidor, [database] = @database, [user] = @user, [password] = @password, [odbc] = @odbc WHERE id = @id";

                    myCmd.Parameters.AddRange(new OleDbParameter[]
           {
               new OleDbParameter("@codigo", textBox1.Text),
               new OleDbParameter("@empresa", textBox2.Text),
               new OleDbParameter("@servidor", textBox3.Text),
               new OleDbParameter("@database", textBox4.Text),
               new OleDbParameter("@user", textBox5.Text),
               new OleDbParameter("@password", textBox6.Text),
               new OleDbParameter("@odbc", textBox7.Text),
               new OleDbParameter("@id", textBox8.Text),

           });

                    try
                    {
                        myConn.Open();
                        myCmd.ExecuteNonQuery();
                        myConn.Close();

                        AlteraBotoes(1);
                    }
                    catch (OdbcException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                AlteraBotoes(1);
            }
            LimparDados();
            Pesquisa();
        }

        private void Excluir()
        {
            if (MessageBox.Show("Deseja realmente excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string strSQL = @"DELETE FROM empresas where id = @id";

                try
                {
                    // cria objetos de ADOConnection e ADOCommand
                    OleDbConnection myConn = new OleDbConnection(strDSN);
                    OleDbDataAdapter myCmd = new OleDbDataAdapter(strSQL, myConn);
                    myCmd.SelectCommand.Parameters.AddWithValue("@id", DgvDados.CurrentRow.Cells[0].Value.ToString());
                    myConn.Open();
                    myCmd.SelectCommand.ExecuteNonQuery();
                    myConn.Close();
                }
                catch (OdbcException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            Pesquisa();
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void DgvDados_DoubleClick(object sender, EventArgs e)
        {
            Abrir();
        }
    }
}
