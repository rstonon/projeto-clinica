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
    public partial class FrmCidadesCadastro : Form
    {
        public int codigo;
        public string operacao;
        public string origem;
        FrmCidades form;

        public FrmCidadesCadastro(FrmCidades form)
        {
            InitializeComponent();
            this.form = form;
        }

        public void LimparDados()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            checkBox1.Checked = true;
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
                    ModelCidades model = new ModelCidades();
                    model.Status = checkBox1.Checked;
                    model.Cidade = textBox2.Text;
                    model.Uf = comboBox1.Text;
                    model.Codigo_ibge = textBox3.Text;

                    DALConexao conn = new DALConexao(DadosConexao.StringConexao);
                    BLLCidades bll = new BLLCidades(conn);

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
            textBox1.Text = this.codigo.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DALConexao conn = new DALConexao(DadosConexao.StringConexao);
                BLLCidades bll = new BLLCidades(conn);
                ModelCidades model = bll.CarregarGrid(codigo);
                textBox1.Text = model.Id.ToString();
                checkBox1.Checked = model.Status;
                textBox2.Text = model.Cidade;
                comboBox1.Text = model.Uf;
                textBox3.Text = model.Codigo_ibge;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.SelectionStart = 0;
                textBox2.SelectionLength = textBox2.Text.Length;
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox3.Text))
            {
                textBox3.SelectionStart = 0;
                textBox3.SelectionLength = textBox3.Text.Length;
            }
        }
    }
}
