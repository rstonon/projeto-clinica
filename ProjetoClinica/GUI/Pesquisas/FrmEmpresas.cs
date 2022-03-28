using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmEmpresas : Form
    {

        public int codigo = 0;
        public string origem;
        public string pesquisarPor;
        public string status;
        public string tipo;
        public void AlteraBotoes(int op)
        {
            BtnNovo.Visible = false;
            BtnAbrir.Visible = false;
            BtnExcluir.Visible = false;
            BtnRelatorios.Visible = false;
            BtnPesquisa.Visible = false;

            if (op == 1)
            {
                BtnNovo.Visible = true;
                BtnAbrir.Visible = true;
                BtnExcluir.Visible = true;
                BtnRelatorios.Visible = true;
                tbcDados.SelectedTab = tpPesquisa;
            }

            if (op == 2)
            {
                BtnPesquisa.Visible = true;
                tbcDados.SelectedTab = tpRelatorios;
            }
        }

        public void PesquisaSql()
        {
            DALConexao conn = new DALConexao(DadosConexao.StringConexao);
            BLLEmpresas bll = new BLLEmpresas(conn);

            DgvDados.DataSource = bll.PesquisaSql(cbxPesquisarPor.Text, txtPalavraChave.Text);


            CarregarDados();
        }

        private void CarregarDados()
        {
            DgvDados.Columns[0].HeaderText = "Código";
            DgvDados.Columns[0].Width = 80;
            DgvDados.Columns[1].HeaderText = "Razão Social";
            DgvDados.Columns[1].Width = 550;
            DgvDados.Columns[2].Visible = false;
            DgvDados.Columns[3].HeaderText = "Telefone";
            DgvDados.Columns[3].Width = 100;
            DgvDados.Columns[4].HeaderText = "Cidade";
            DgvDados.Columns[4].Width = 150;
            DgvDados.Columns[5].HeaderText = "UF";
            DgvDados.Columns[5].Width = 50;
        }

        public void Excluir()
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d.ToString().Equals("Yes"))
                {
                    DALConexao conn = new DALConexao(DadosConexao.StringConexao);
                    BLLEmpresas bll = new BLLEmpresas(conn);
                    bll.Excluir(Convert.ToInt32(DgvDados.CurrentRow.Cells[0].Value.ToString()));
                }
                PesquisaSql();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Relatórios()
        {
            AlteraBotoes(2);
        }
        private void Lista()
        {
            AlteraBotoes(1);
        }

        private void Novo()
        {
            FrmEmpresasCadastro f = new FrmEmpresasCadastro()
            {
                operacao = "Inclusão"
            };
            f.ShowDialog();
            f.LimparDados();
        }

        private void Abrir()
        {
            if (DgvDados.Rows.Count > 0)
            {
                codigo = Convert.ToInt32(DgvDados.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("Favor selecionar um registro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmEmpresasCadastro f = new FrmEmpresasCadastro()
            {
                codigo = this.codigo,
                operacao = "Edição"
            };
            f.ShowDialog();

        }

        public FrmEmpresas()
        {
            InitializeComponent();
        }

        private void FrmColaboradoresTipo_Load(object sender, EventArgs e)
        {
            if (pnSelecionar.Visible == false)
            {
                DgvDados.Height = 609;
            }
            else
            {
                DgvDados.Height = 534;
            }

            if (pesquisarPor == null)
            {
                cbxPesquisarPor.Text = "Razão Social";
            }
            else
            {
                cbxPesquisarPor.Text = pesquisarPor;
            }

            AlteraBotoes(1);
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            Lista();
        }

        private void FrmModelo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
            if (e.KeyCode == Keys.F1)
            {
                Novo();
            }
            if (e.KeyCode == Keys.F2)
            {
                Abrir();
            }
            if (e.KeyCode == Keys.F6)
            {
                Excluir();
            }
            if (e.KeyCode == Keys.F7)
            {
                Relatórios();
            }
            if (e.KeyCode == Keys.F8)
            {
                Lista();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisaSql();
        }

        private void BtnRelatorios_Click(object sender, EventArgs e)
        {
            Relatórios();
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void DgvDados_DoubleClick(object sender, EventArgs e)
        {
            Abrir();
        }
    }
}
