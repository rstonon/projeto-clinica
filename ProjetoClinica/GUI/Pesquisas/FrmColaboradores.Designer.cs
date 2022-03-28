namespace GUI
{
    partial class FrmColaboradores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmColaboradores));
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.BtnRelatorios = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnPesquisa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbcDados = new System.Windows.Forms.TabControl();
            this.tpPesquisa = new System.Windows.Forms.TabPage();
            this.DgvDados = new System.Windows.Forms.DataGridView();
            this.pnPesquisa = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPalavraChave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPesquisarPor = new System.Windows.Forms.ComboBox();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.pnSelecionar = new System.Windows.Forms.Panel();
            this.BtnSelecionar = new System.Windows.Forms.Button();
            this.tpRelatorios = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSelecionarRelatorio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.pnBotoes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbcDados.SuspendLayout();
            this.tpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).BeginInit();
            this.pnPesquisa.SuspendLayout();
            this.pnSelecionar.SuspendLayout();
            this.tpRelatorios.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotoes
            // 
            this.pnBotoes.Controls.Add(this.BtnRelatorios);
            this.pnBotoes.Controls.Add(this.BtnExcluir);
            this.pnBotoes.Controls.Add(this.BtnAbrir);
            this.pnBotoes.Controls.Add(this.BtnNovo);
            this.pnBotoes.Controls.Add(this.BtnPesquisa);
            this.pnBotoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(129, 729);
            this.pnBotoes.TabIndex = 1;
            // 
            // BtnRelatorios
            // 
            this.BtnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRelatorios.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelatorios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("BtnRelatorios.Image")));
            this.BtnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRelatorios.Location = new System.Drawing.Point(7, 159);
            this.BtnRelatorios.Name = "BtnRelatorios";
            this.BtnRelatorios.Size = new System.Drawing.Size(117, 46);
            this.BtnRelatorios.TabIndex = 0;
            this.BtnRelatorios.Text = "Relatórios";
            this.BtnRelatorios.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnRelatorios.UseVisualStyleBackColor = true;
            this.BtnRelatorios.Click += new System.EventHandler(this.BtnRelatorios_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcluir.Image")));
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcluir.Location = new System.Drawing.Point(7, 107);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(117, 46);
            this.BtnExcluir.TabIndex = 0;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAbrir.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("BtnAbrir.Image")));
            this.BtnAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAbrir.Location = new System.Drawing.Point(7, 56);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(117, 46);
            this.BtnAbrir.TabIndex = 0;
            this.BtnAbrir.Text = "Abrir";
            this.BtnAbrir.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnAbrir.UseVisualStyleBackColor = true;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNovo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnNovo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNovo.Image")));
            this.BtnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNovo.Location = new System.Drawing.Point(7, 5);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(117, 46);
            this.BtnNovo.TabIndex = 0;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click_1);
            // 
            // BtnPesquisa
            // 
            this.BtnPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPesquisa.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("BtnPesquisa.Image")));
            this.BtnPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPesquisa.Location = new System.Drawing.Point(7, 5);
            this.BtnPesquisa.Name = "BtnPesquisa";
            this.BtnPesquisa.Size = new System.Drawing.Size(117, 46);
            this.BtnPesquisa.TabIndex = 0;
            this.BtnPesquisa.Text = "Pesquisa";
            this.BtnPesquisa.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnPesquisa.UseVisualStyleBackColor = true;
            this.BtnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbcDados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(129, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 729);
            this.panel1.TabIndex = 4;
            // 
            // tbcDados
            // 
            this.tbcDados.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tbcDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcDados.Controls.Add(this.tpPesquisa);
            this.tbcDados.Controls.Add(this.tpRelatorios);
            this.tbcDados.Location = new System.Drawing.Point(5, 5);
            this.tbcDados.Name = "tbcDados";
            this.tbcDados.Padding = new System.Drawing.Point(50, 3);
            this.tbcDados.SelectedIndex = 0;
            this.tbcDados.Size = new System.Drawing.Size(1130, 741);
            this.tbcDados.TabIndex = 0;
            // 
            // tpPesquisa
            // 
            this.tpPesquisa.Controls.Add(this.DgvDados);
            this.tpPesquisa.Controls.Add(this.pnPesquisa);
            this.tpPesquisa.Controls.Add(this.pnSelecionar);
            this.tpPesquisa.Location = new System.Drawing.Point(4, 4);
            this.tpPesquisa.Name = "tpPesquisa";
            this.tpPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tpPesquisa.Size = new System.Drawing.Size(1122, 715);
            this.tpPesquisa.TabIndex = 0;
            this.tpPesquisa.Text = "Pesquisa";
            this.tpPesquisa.UseVisualStyleBackColor = true;
            // 
            // DgvDados
            // 
            this.DgvDados.AllowUserToAddRows = false;
            this.DgvDados.AllowUserToDeleteRows = false;
            this.DgvDados.AllowUserToOrderColumns = true;
            this.DgvDados.AllowUserToResizeColumns = false;
            this.DgvDados.AllowUserToResizeRows = false;
            this.DgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDados.Location = new System.Drawing.Point(3, 90);
            this.DgvDados.Name = "DgvDados";
            this.DgvDados.ReadOnly = true;
            this.DgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDados.Size = new System.Drawing.Size(1116, 557);
            this.DgvDados.TabIndex = 2;
            this.DgvDados.Text = "dataGridView1";
            this.DgvDados.DoubleClick += new System.EventHandler(this.DgvDados_DoubleClick);
            // 
            // pnPesquisa
            // 
            this.pnPesquisa.Controls.Add(this.label4);
            this.pnPesquisa.Controls.Add(this.cbxTipo);
            this.pnPesquisa.Controls.Add(this.label3);
            this.pnPesquisa.Controls.Add(this.cbxStatus);
            this.pnPesquisa.Controls.Add(this.label2);
            this.pnPesquisa.Controls.Add(this.txtPalavraChave);
            this.pnPesquisa.Controls.Add(this.label1);
            this.pnPesquisa.Controls.Add(this.cbxPesquisarPor);
            this.pnPesquisa.Controls.Add(this.BtnPesquisar);
            this.pnPesquisa.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPesquisa.Location = new System.Drawing.Point(3, 3);
            this.pnPesquisa.Name = "pnPesquisa";
            this.pnPesquisa.Size = new System.Drawing.Size(1116, 87);
            this.pnPesquisa.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo",
            "Todos"});
            this.cbxStatus.Location = new System.Drawing.Point(229, 44);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(104, 21);
            this.cbxStatus.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Palavra-Chave";
            // 
            // txtPalavraChave
            // 
            this.txtPalavraChave.Location = new System.Drawing.Point(339, 44);
            this.txtPalavraChave.Name = "txtPalavraChave";
            this.txtPalavraChave.Size = new System.Drawing.Size(202, 20);
            this.txtPalavraChave.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar Por";
            // 
            // cbxPesquisarPor
            // 
            this.cbxPesquisarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPesquisarPor.FormattingEnabled = true;
            this.cbxPesquisarPor.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "Número Documento"});
            this.cbxPesquisarPor.Location = new System.Drawing.Point(9, 44);
            this.cbxPesquisarPor.Name = "cbxPesquisarPor";
            this.cbxPesquisarPor.Size = new System.Drawing.Size(104, 21);
            this.cbxPesquisarPor.TabIndex = 1;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPesquisar.Image")));
            this.BtnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPesquisar.Location = new System.Drawing.Point(995, 18);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(117, 46);
            this.BtnPesquisar.TabIndex = 0;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // pnSelecionar
            // 
            this.pnSelecionar.Controls.Add(this.BtnSelecionar);
            this.pnSelecionar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnSelecionar.Location = new System.Drawing.Point(3, 647);
            this.pnSelecionar.Name = "pnSelecionar";
            this.pnSelecionar.Size = new System.Drawing.Size(1116, 65);
            this.pnSelecionar.TabIndex = 0;
            this.pnSelecionar.Visible = false;
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelecionar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelecionar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSelecionar.Image")));
            this.BtnSelecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSelecionar.Location = new System.Drawing.Point(994, 15);
            this.BtnSelecionar.Name = "BtnSelecionar";
            this.BtnSelecionar.Size = new System.Drawing.Size(117, 46);
            this.BtnSelecionar.TabIndex = 0;
            this.BtnSelecionar.Text = "Selecionar";
            this.BtnSelecionar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnSelecionar.UseVisualStyleBackColor = true;
            // 
            // tpRelatorios
            // 
            this.tpRelatorios.Controls.Add(this.panel2);
            this.tpRelatorios.Location = new System.Drawing.Point(4, 4);
            this.tpRelatorios.Name = "tpRelatorios";
            this.tpRelatorios.Padding = new System.Windows.Forms.Padding(3);
            this.tpRelatorios.Size = new System.Drawing.Size(1122, 715);
            this.tpRelatorios.TabIndex = 1;
            this.tpRelatorios.Text = "Relatórios";
            this.tpRelatorios.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnSelecionarRelatorio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 647);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1116, 65);
            this.panel2.TabIndex = 0;
            // 
            // BtnSelecionarRelatorio
            // 
            this.BtnSelecionarRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelecionarRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelecionarRelatorio.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnSelecionarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelecionarRelatorio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSelecionarRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("BtnSelecionarRelatorio.Image")));
            this.BtnSelecionarRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSelecionarRelatorio.Location = new System.Drawing.Point(995, 10);
            this.BtnSelecionarRelatorio.Name = "BtnSelecionarRelatorio";
            this.BtnSelecionarRelatorio.Size = new System.Drawing.Size(117, 46);
            this.BtnSelecionarRelatorio.TabIndex = 0;
            this.BtnSelecionarRelatorio.Text = "Selecionar";
            this.BtnSelecionarRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnSelecionarRelatorio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo";
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Ativo",
            "Inativo",
            "Todos"});
            this.cbxTipo.Location = new System.Drawing.Point(119, 44);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(104, 21);
            this.cbxTipo.TabIndex = 4;
            // 
            // FrmColaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmColaboradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colaboradores";
            this.Load += new System.EventHandler(this.FrmColaboradoresTipo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmModelo_KeyDown);
            this.pnBotoes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tbcDados.ResumeLayout(false);
            this.tpPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).EndInit();
            this.pnPesquisa.ResumeLayout(false);
            this.pnPesquisa.PerformLayout();
            this.pnSelecionar.ResumeLayout(false);
            this.tpRelatorios.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tpPesquisa;
        private System.Windows.Forms.TabPage tpRelatorios;
        private System.Windows.Forms.Button BtnPesquisa;
        protected System.Windows.Forms.Panel pnBotoes;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button BtnNovo;
        protected System.Windows.Forms.TabControl tbcDados;
        protected System.Windows.Forms.Button BtnRelatorios;
        protected System.Windows.Forms.Button BtnExcluir;
        protected System.Windows.Forms.Button BtnAbrir;
        protected System.Windows.Forms.DataGridView DgvDados;
        protected System.Windows.Forms.Panel pnPesquisa;
        protected System.Windows.Forms.Panel pnSelecionar;
        protected System.Windows.Forms.Button BtnSelecionar;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Button BtnSelecionarRelatorio;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPalavraChave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPesquisarPor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTipo;
    }
}