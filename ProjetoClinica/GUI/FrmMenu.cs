using BLL;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmMenu : Form
    {
        public int id_empresa;
        public int id_usuario;
        public int id_perfil;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCidades f = new FrmCidades();
            f.ShowDialog();
        }

        private void tipoColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {

             if (PermissoesUsuario.Tipos_visualizar == false && PermissoesUsuario.Tipos_cadastrar == false && PermissoesUsuario.Tipos_editar == false && PermissoesUsuario.Tipos_excluir == false && PermissoesUsuario.Tipos_relatorios == false)
            {
                MessageBox.Show("Usuário sem permissão para acessar essa tela.");
                return;
            }

            FrmTipos f = new FrmTipos();
            f.ShowDialog();
        }

        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmColaboradores f = new FrmColaboradores();
            f.ShowDialog();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGrupos f = new FrmGrupos();
            f.ShowDialog();
        }

        private void documentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDocumentos f = new FrmDocumentos();
            f.ShowDialog();
        }

        private void unidadesDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUnidadesMedida f = new FrmUnidadesMedida();
            f.ShowDialog();
        }

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsuarios f = new FrmUsuarios();
            f.ShowDialog();
        }

        private void perfisUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPerfisUsuarios f = new FrmPerfisUsuarios();
            f.ShowDialog();
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void CarregarPermissoes()
        {
            DALConexao conn = new DALConexao(DadosConexao.StringConexao);
            BLLPerfisUsuarios bll = new BLLPerfisUsuarios(conn);
            ModelUsuariosPermissoes model = bll.CarregarGrid(id_perfil);

            PermissoesUsuario.Id_perfil = Convert.ToInt32(IdPerfilStripLabel1.Text);
            PermissoesUsuario.Tipos_visualizar = model.TiposVisualizar;
            PermissoesUsuario.Tipos_cadastrar = model.TiposCadastrar;
            PermissoesUsuario.Tipos_editar = model.TiposEditar;
            PermissoesUsuario.Tipos_excluir = model.TiposExcluir;
            PermissoesUsuario.Tipos_relatorios = model.TiposRelatorios;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmColaboradores f = new FrmColaboradores();
            f.ShowDialog();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            MessageBox.Show(id_empresa.ToString());

            idEmpresaStripLabel1.Text = id_empresa.ToString();
            //IdPerfilStripLabel1.Text = id_perfil.ToString();
            //idUsuarioStripLabel1.Text = id_usuario.ToString();
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpresasCadastro f = new FrmEmpresasCadastro()
            {
                codigo = Convert.ToInt32(idEmpresaStripLabel1.Text),
                operacao = "Edição"
            };
            f.ShowDialog();
        }

        private void idEmpresaStripLabel1_TextChanged(object sender, EventArgs e)
        {
            idEmpresaStripLabel1.Text = id_empresa.ToString();
            CarregarConfiguracoes();

            empresaStripLabel1.Text = Configuracoes.Razao_social;
        }

        public void CarregarConfiguracoes()
        {
            DALConexao conn = new DALConexao(DadosConexao.StringConexao);
            BLLEmpresas bll = new BLLEmpresas(conn);
            ModelEmpresas model = bll.CarregarGrid(id_empresa);

            Configuracoes.Id = Convert.ToInt32(model.Id);
            Configuracoes.Cpf_cnpj = model.Cpf_cnpj;
            Configuracoes.Inscricao_estadual = model.Inscricao_estadual;
            Configuracoes.Inscricao_municipal = model.Inscricao_municipal;
            Configuracoes.Razao_social = model.Razao_social;
            Configuracoes.Nome_fantasia = model.Nome_fantasia;
            Configuracoes.Endereco = model.Endereco;
            Configuracoes.Numero = model.Numero;
            Configuracoes.Complemento = model.Complemento;
            Configuracoes.Bairro = model.Bairro;
            Configuracoes.Id_cidade = Convert.ToInt32(model.Id_cidade);
            Configuracoes.Cep = model.Cep;
            Configuracoes.Email = model.Email;
            Configuracoes.Telefone = model.Telefone;
            Configuracoes.Cor = model.Cor;

        }

        private void IdPerfilStripLabel1_TextChanged(object sender, EventArgs e)
        {
            CarregarPermissoes();
        }
    }
}
