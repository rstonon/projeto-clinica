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
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using static GUI.Auxiliares;

namespace GUI
{

    public partial class FrmColaboradoresCadastro : Form
    {
        public int codigo = 0;
        public string operacao;
        public string origem;
        public string foto = "";
        FrmColaboradores form;

        public FrmColaboradoresCadastro(FrmColaboradores form)
        {
            InitializeComponent();
            this.form = form;
        }

        public void LimparDados()
        {
            codigo = 0;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            comboBox1.Text = "";
            checkBox1.Checked = true;
            pictureBox1.Image = null;
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
                    ModelColaboradores model = new ModelColaboradores();
                    model.Status = checkBox1.Checked;
                    model.Numero_documento = textBox2.Text;
                    model.Id_tipo = Convert.ToInt32(comboBox1.SelectedValue);
                    model.Razao_social = textBox3.Text;
                    model.Rg = textBox4.Text;
                    model.Telefone = maskedTextBox1.Text;
                    model.Celular = maskedTextBox2.Text;
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
                    model.Imagem = pictureBox1.ImageLocation;


                    DALConexao conn = new DALConexao(DadosConexao.StringConexao);
                    BLLColaboradores bll = new BLLColaboradores(conn);

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
            DALConexao conn = new DALConexao(DadosConexao.StringConexao);
            BLLTipos bll = new BLLTipos(conn);
            comboBox1.DataSource = bll.PesquisaSql("Descrição", "Ativo", "Colaborador", "");
            comboBox1.DisplayMember = "descricao";
            comboBox1.ValueMember = "id";

            textBox1.Text = this.codigo.ToString();
            comboBox1.Text = "Cliente";
            checkBox1.Checked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (codigo != 0)
            {
                try
                {
                    DALConexao conn = new DALConexao(DadosConexao.StringConexao);
                    BLLColaboradores bll = new BLLColaboradores(conn);
                    ModelColaboradores model = bll.CarregarGrid(codigo);
                    textBox1.Text = model.Id.ToString();
                    checkBox1.Checked = model.Status;

                    comboBox1.SelectedValue = model.Id_tipo;
                    textBox2.Text = model.Numero_documento;
                    textBox3.Text = model.Razao_social;
                    textBox4.Text = model.Rg;
                    maskedTextBox1.Text = model.Telefone;
                    maskedTextBox2.Text = model.Celular;
                    textBox7.Text = model.Endereco;
                    textBox8.Text = model.Numero;
                    textBox9.Text = model.Complemento;
                    textBox10.Text = model.Bairro;
                    textBox15.Text = model.Id_cidade.ToString();
                    textBox13.Text = model.Cep;
                    textBox14.Text = model.Email;
                    if (model.Imagem != "")
                    {
                        pictureBox1.Load(model.Imagem);
                    }
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

        private void button3_Click(object sender, EventArgs e)
        {
            FrmTipos f = new FrmTipos();
            f.ShowDialog();
            f.Dispose();

            DALConexao conn = new DALConexao(DadosConexao.StringConexao);
            BLLTipos bll = new BLLTipos(conn);
            comboBox1.DataSource = bll.PesquisaSql("Descrição", "Ativo", "Colaborador", "");
            comboBox1.DisplayMember = "tipo";
            comboBox1.ValueMember = "id";
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

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (operacao.Equals("Inclusão"))
            {
                int r = 0;
                DALConexao conn = new DALConexao(DadosConexao.StringConexao);
                BLLColaboradores bll = new BLLColaboradores(conn);
                r = bll.VerificaCPFCNPJ(textBox2.Text);
                if (r > 0)
                {
                    MessageBox.Show("Já existe um registro com esse Número de Documento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (textBox2.TextLength == 14)
            {
                textBox2.Text = FormatCnpjCpf.FormatCNPJ(textBox2.Text);
            }
            if (textBox2.TextLength == 11)
            {
                textBox2.Text = FormatCnpjCpf.FormatCPF(textBox2.Text);
            }
        }

        private void textBox2_GotFocus(Object sender, EventArgs e)
        {
            textBox2.Text = FormatCnpjCpf.SemFormatacao(textBox2.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string cep = textBox13.Text;
            cep = cep.Replace("-", "");

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + cep + "/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Servidor indisponível");
                return; // Sai da rotina
            }

            using (Stream webStream = ChecaServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        string response = responseReader.ReadToEnd();
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");

                        String[] substrings = response.Split('\n');

                        string cidade = "";
                        string uf = "";

                        int cont = 0;
                        foreach (var substring in substrings)
                        {
                            if (cont == 1)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                if (valor[0] == "  erro")
                                {
                                    MessageBox.Show("CEP não encontrado");
                                    textBox13.Focus();
                                    return;
                                }
                            }

                            //Logradouro
                            if (cont == 2)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                textBox7.Text = valor[1];
                            }

                            textBox8.Clear();

                            //Complemento
                            if (cont == 3)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                textBox9.Text = valor[1];
                            }

                            //Bairro
                            if (cont == 4)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                textBox10.Text = valor[1];
                            }



                            //Localidade (Cidade)
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                cidade = valor[1];
                            }

                            ////Estado (UF)
                            if (cont == 6)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                uf = valor[1];
                            }

                            cidade = cidade.Trim();
                            uf = uf.Trim();

                            DALConexao conn = new DALConexao(DadosConexao.StringConexao);
                            BLLCidades bll = new BLLCidades(conn);
                            ModelCidades model = bll.PesquisaCidadesPorNome(cidade, uf);
                            textBox15.Text = model.Id.ToString();

                            cont++;
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (od.FileName != "")
            {
                this.foto = od.FileName;
                pictureBox1.Load(this.foto);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
