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
    public partial class FrmPerfisUsuariosCadastro : Form
    {
        public int codigo;
        public string operacao;
        public string origem;
        FrmPerfisUsuarios form;

        public FrmPerfisUsuariosCadastro(FrmPerfisUsuarios form)
        {
            InitializeComponent();
            this.form = form;
        }

        public void LimparDados()
        {
            textBox1.Clear();
            textBox2.Clear();
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
                    ModelUsuariosPermissoes model = new ModelUsuariosPermissoes();
                    model.Descricao = textBox2.Text;
                    model.TiposVisualizar = checkBox5.Checked;
                    model.TiposCadastrar = checkBox2.Checked;
                    model.TiposEditar = checkBox3.Checked;
                    model.TiposExcluir = checkBox4.Checked;
                    model.TiposRelatorios = checkBox6.Checked;

                    DALConexao conn = new DALConexao(DadosConexao.StringConexao);
                    BLLPerfisUsuarios bll = new BLLPerfisUsuarios(conn);

                    if (operacao.Equals("Inclusão"))
                    {
                        bll.Adicionar(model);
                    }
                    else
                    {
                        model.Id = Convert.ToInt32(textBox1.Text);
                        bll.Editar(model);

                        FrmMenu f = new FrmMenu();
                        f.IdPerfilStripLabel1.Text = textBox1.Text;
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
                BLLPerfisUsuarios bll = new BLLPerfisUsuarios(conn);
                ModelUsuariosPermissoes model = bll.CarregarGrid(codigo);
                textBox1.Text = model.Id.ToString();
                textBox2.Text = model.Descricao;
                checkBox5.Checked = model.TiposVisualizar;
                checkBox2.Checked = model.TiposCadastrar;
                checkBox3.Checked = model.TiposEditar;
                checkBox4.Checked = model.TiposExcluir;
                checkBox6.Checked = model.TiposRelatorios;
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
    }
}
