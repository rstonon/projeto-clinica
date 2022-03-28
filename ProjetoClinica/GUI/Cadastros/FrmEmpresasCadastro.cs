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
using static GUI.Auxiliares;

namespace GUI
{
    public partial class FrmEmpresasCadastro : Form
    {
        public int codigo;
        public string operacao;
        public string origem;
        public int id_empresa;


        public FrmEmpresasCadastro()
        {
            InitializeComponent();
        }

        public void LimparDados()
        {
            codigo = 0;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            maskedTextBox1.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
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
                    ModelEmpresas model = new ModelEmpresas();
                    model.Razao_social = textBox2.Text;
                    model.Cpf_cnpj = textBox3.Text;
                    model.Nome_fantasia = textBox6.Text;
                    model.Inscricao_estadual = textBox4.Text;
                    model.Inscricao_municipal = textBox5.Text;
                    model.Endereco = textBox7.Text;
                    model.Numero = textBox8.Text;
                    model.Complemento = textBox9.Text;
                    model.Bairro = textBox10.Text;
                    if (textBox15.Text != "")
                    {
                        model.Id_cidade = Convert.ToInt32(textBox15.Text);
                    }
                    model.Cep = textBox13.Text;
                    model.Email = textBox14.Text;
                    model.Cor = textBox16.Text;
                    model.Telefone = maskedTextBox1.Text;

                    DALConexao conn = new DALConexao(DadosConexao.StringConexao);
                    BLLEmpresas bll = new BLLEmpresas(conn);

                    if (operacao.Equals("Inclusão"))
                    {
                        bll.Adicionar(model);
                    }
                    else
                    {
                        model.Id = Convert.ToInt32(textBox1.Text);
                        bll.Editar(model);
                    }

                    FrmMenu f = new FrmMenu();
                    f.id_empresa = Convert.ToInt32(textBox1.Text);
                    f.idEmpresaStripLabel1.Text = textBox1.Text;
                    f.CarregarConfiguracoes(); ;

                    this.LimparDados();
                    this.Close();
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
            BLLUsuarios bll = new BLLUsuarios(conn);
            ModelUsuarios model = bll.CarregarGrid(codigo);

            //textBox1.Text = model.Id_empresa.ToString();

            //textBox1.Text = this.codigo.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DALConexao conn = new DALConexao(DadosConexao.StringConexao);
                BLLEmpresas bll = new BLLEmpresas(conn);
                ModelEmpresas model = bll.CarregarGrid(codigo);

                textBox1.Text = model.Id.ToString();
                textBox2.Text = model.Razao_social;
                textBox3.Text = model.Cpf_cnpj;
                textBox6.Text = model.Nome_fantasia;
                textBox4.Text = model.Inscricao_estadual;
                textBox5.Text = model.Inscricao_municipal;
                textBox7.Text = model.Endereco;
                textBox8.Text = model.Numero;
                textBox9.Text = model.Complemento;
                textBox10.Text = model.Bairro;
                textBox15.Text = model.Id_cidade.ToString();
                textBox13.Text = model.Cep;
                textBox14.Text = model.Email;
                textBox16.Text = model.Cor;
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox16.Text = ColorTranslator.ToHtml(colorDialog1.Color);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCidades f = new FrmCidades();
            f.pnSelecionar.Visible = true;
            f.ShowDialog();

            if (f.codigo != 0)
            {
                DALConexao conn = new DALConexao(DadosConexao.StringConexao);
                BLLCidades bll = new BLLCidades(conn);
                ModelCidades model = bll.CarregarGrid(f.codigo);
                textBox15.Text = model.Id.ToString();
                textBox11.Text = model.Cidade;
                textBox12.Text = model.Uf;
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            textBox17.BackColor = ColorTranslator.FromHtml(textBox16.Text);
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.TextLength == 14)
            {
                textBox3.Text = FormatCnpjCpf.FormatCNPJ(textBox3.Text);
            }
            if (textBox3.TextLength == 11)
            {
                textBox3.Text = FormatCnpjCpf.FormatCPF(textBox3.Text);
            }
        }

        private void textBox3_GotFocus(Object sender, EventArgs e)
        {
            textBox3.Text = FormatCnpjCpf.SemFormatacao(textBox3.Text);
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text != "")
            {
                DALConexao conn = new DALConexao(DadosConexao.StringConexao);
                BLLCidades bll = new BLLCidades(conn);
                ModelCidades model = bll.CarregarGrid(Convert.ToInt32(textBox15.Text));
                textBox15.Text = model.Id.ToString();
                textBox11.Text = model.Cidade;
                textBox12.Text = model.Uf;
            }
        }

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                textBox11.Clear();
                textBox12.Clear();
                textBox15.Clear();
            }
        }
    }
}
