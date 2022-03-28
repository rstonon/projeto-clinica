namespace GUI
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaboradoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoColaboradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadesDeMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.perfisUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.UsuarioStatusLabel = new System.Windows.Forms.ToolStripLabel();
            this.idUsuarioStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.IdPerfilStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.empresaStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.idEmpresaStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.utilitáriosToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cidadesToolStripMenuItem,
            this.colaboradoresToolStripMenuItem,
            this.documentosToolStripMenuItem,
            this.gruposToolStripMenuItem,
            this.tipoColaboradorToolStripMenuItem,
            this.unidadesDeMedidaToolStripMenuItem,
            this.toolStripSeparator1,
            this.usuáriosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cidadesToolStripMenuItem
            // 
            this.cidadesToolStripMenuItem.Name = "cidadesToolStripMenuItem";
            this.cidadesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cidadesToolStripMenuItem.Text = "Cidades";
            this.cidadesToolStripMenuItem.Click += new System.EventHandler(this.cidadesToolStripMenuItem_Click);
            // 
            // colaboradoresToolStripMenuItem
            // 
            this.colaboradoresToolStripMenuItem.Name = "colaboradoresToolStripMenuItem";
            this.colaboradoresToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.colaboradoresToolStripMenuItem.Text = "Colaboradores";
            this.colaboradoresToolStripMenuItem.Click += new System.EventHandler(this.colaboradoresToolStripMenuItem_Click);
            // 
            // documentosToolStripMenuItem
            // 
            this.documentosToolStripMenuItem.Name = "documentosToolStripMenuItem";
            this.documentosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.documentosToolStripMenuItem.Text = "Documentos";
            this.documentosToolStripMenuItem.Click += new System.EventHandler(this.documentosToolStripMenuItem_Click);
            // 
            // gruposToolStripMenuItem
            // 
            this.gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            this.gruposToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.gruposToolStripMenuItem.Text = "Grupos";
            this.gruposToolStripMenuItem.Click += new System.EventHandler(this.gruposToolStripMenuItem_Click);
            // 
            // tipoColaboradorToolStripMenuItem
            // 
            this.tipoColaboradorToolStripMenuItem.Name = "tipoColaboradorToolStripMenuItem";
            this.tipoColaboradorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tipoColaboradorToolStripMenuItem.Text = "Tipos";
            this.tipoColaboradorToolStripMenuItem.Click += new System.EventHandler(this.tipoColaboradorToolStripMenuItem_Click);
            // 
            // unidadesDeMedidaToolStripMenuItem
            // 
            this.unidadesDeMedidaToolStripMenuItem.Name = "unidadesDeMedidaToolStripMenuItem";
            this.unidadesDeMedidaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.unidadesDeMedidaToolStripMenuItem.Text = "Unidades de Medida";
            this.unidadesDeMedidaToolStripMenuItem.Click += new System.EventHandler(this.unidadesDeMedidaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem1,
            this.perfisUsuáriosToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // usuáriosToolStripMenuItem1
            // 
            this.usuáriosToolStripMenuItem1.Name = "usuáriosToolStripMenuItem1";
            this.usuáriosToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.usuáriosToolStripMenuItem1.Text = "Usuários";
            this.usuáriosToolStripMenuItem1.Click += new System.EventHandler(this.usuáriosToolStripMenuItem1_Click);
            // 
            // perfisUsuáriosToolStripMenuItem
            // 
            this.perfisUsuáriosToolStripMenuItem.Name = "perfisUsuáriosToolStripMenuItem";
            this.perfisUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.perfisUsuáriosToolStripMenuItem.Text = "Perfis Usuários";
            this.perfisUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.perfisUsuáriosToolStripMenuItem_Click);
            // 
            // utilitáriosToolStripMenuItem
            // 
            this.utilitáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem});
            this.utilitáriosToolStripMenuItem.Name = "utilitáriosToolStripMenuItem";
            this.utilitáriosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.utilitáriosToolStripMenuItem.Text = "Utilitários";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            this.configuraçõesToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 82);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(88, 79);
            this.toolStripButton1.Text = "Colaboradores";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 82);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AllowItemReorder = true;
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuarioStatusLabel,
            this.idUsuarioStripLabel1,
            this.IdPerfilStripLabel1,
            this.toolStripSeparator3,
            this.empresaStripLabel1,
            this.idEmpresaStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 704);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // UsuarioStatusLabel
            // 
            this.UsuarioStatusLabel.Image = ((System.Drawing.Image)(resources.GetObject("UsuarioStatusLabel.Image")));
            this.UsuarioStatusLabel.Name = "UsuarioStatusLabel";
            this.UsuarioStatusLabel.Size = new System.Drawing.Size(116, 22);
            this.UsuarioStatusLabel.Text = "Nome do Usuário";
            // 
            // idUsuarioStripLabel1
            // 
            this.idUsuarioStripLabel1.Name = "idUsuarioStripLabel1";
            this.idUsuarioStripLabel1.Size = new System.Drawing.Size(60, 22);
            this.idUsuarioStripLabel1.Text = "Id Usuário";
            this.idUsuarioStripLabel1.Visible = false;
            // 
            // IdPerfilStripLabel1
            // 
            this.IdPerfilStripLabel1.Name = "IdPerfilStripLabel1";
            this.IdPerfilStripLabel1.Size = new System.Drawing.Size(108, 22);
            this.IdPerfilStripLabel1.Text = "ID Perfil do Usuário";
            this.IdPerfilStripLabel1.Visible = false;
            this.IdPerfilStripLabel1.TextChanged += new System.EventHandler(this.IdPerfilStripLabel1_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // empresaStripLabel1
            // 
            this.empresaStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.empresaStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("empresaStripLabel1.Image")));
            this.empresaStripLabel1.Name = "empresaStripLabel1";
            this.empresaStripLabel1.Size = new System.Drawing.Size(120, 22);
            this.empresaStripLabel1.Text = "Nome da Empresa";
            // 
            // idEmpresaStripLabel1
            // 
            this.idEmpresaStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.idEmpresaStripLabel1.Name = "idEmpresaStripLabel1";
            this.idEmpresaStripLabel1.Size = new System.Drawing.Size(66, 22);
            this.idEmpresaStripLabel1.Text = "ID Empresa";
            this.idEmpresaStripLabel1.Visible = false;
            this.idEmpresaStripLabel1.TextChanged += new System.EventHandler(this.idEmpresaStripLabel1_TextChanged);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Clínica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenu_FormClosed);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaboradoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoColaboradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadesDeMedidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem perfisUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        public System.Windows.Forms.ToolStripLabel UsuarioStatusLabel;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripLabel IdPerfilStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem utilitáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        public System.Windows.Forms.ToolStripLabel idUsuarioStripLabel1;
        public System.Windows.Forms.ToolStripLabel idEmpresaStripLabel1;
        private System.Windows.Forms.ToolStripLabel empresaStripLabel1;
    }
}

