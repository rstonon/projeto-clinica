using BLL;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmUsuariosCadastro : Form
    {
        public int codigo;
        public string operacao;
        public string origem;
        FrmUsuarios form;

        public FrmUsuariosCadastro(FrmUsuarios form)
        {
            InitializeComponent();
            this.form = form;
        }

        public void LimparDados()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            checkBox1.Checked = true;
            comboBox1.Text = "";
        }

        private void Cancelar()
        {
            Salvar();
        }

        private void Salvar()
        {
            if (MessageBox.Show("Deseja salvar os dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ModelUsuarios model = new ModelUsuarios();
                    model.Status = checkBox1.Checked;
                    model.Usuario = textBox2.Text;
                    model.Senha = textBox3.Text;
                    model.Id_perfil = Convert.ToInt32(comboBox1.SelectedValue);

                    DALConexao conn = new DALConexao(DadosConexao.StringConexao);
                    BLLUsuarios bll = new BLLUsuarios(conn);

                    if (operacao.Equals("Inclusão"))
                    {
                        bll.Adicionar(model);
                    }
                    else
                    {
                        model.Id = Convert.ToInt32(textBox1.Text);
                        bll.Editar(model);
                    }
                    this.LimparDados();
                    this.Close();
                    form.PesquisaSql();

                    FrmMenu f = new FrmMenu();
                    f.IdPerfilStripLabel1.Text = comboBox1.SelectedValue.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void FrmColaboradoresTipoCadastro_Load(object sender, EventArgs e)
        {
            DALConexao conn = new DALConexao(DadosConexao.StringConexao);
            BLLPerfisUsuarios bll = new BLLPerfisUsuarios(conn);
            comboBox1.DataSource = bll.PesquisaSql("Descrição", "");
            comboBox1.DisplayMember = "descricao";
            comboBox1.ValueMember = "id";

            textBox1.Text = this.codigo.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (codigo != 0)
            {
                try
                {
                    DALConexao conn = new DALConexao(DadosConexao.StringConexao);
                    BLLUsuarios bll = new BLLUsuarios(conn);
                    ModelUsuarios model = bll.CarregarGrid(codigo);
                    textBox1.Text = model.Id.ToString();
                    checkBox1.Checked = model.Status;
                    textBox2.Text = model.Usuario;
                    textBox3.Text = model.Senha;
                    comboBox1.SelectedValue = model.Id_perfil;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FrmColaboradoresTipoCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.F3)
            {
                Salvar();
            }
            if (e.KeyCode == Keys.F4)
            {
                Cancelar();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
