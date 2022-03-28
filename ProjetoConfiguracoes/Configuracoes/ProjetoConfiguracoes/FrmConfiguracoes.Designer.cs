namespace ProjetoConfiguracoes
{
    partial class FrmConfiguracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracoes));
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbcDados = new System.Windows.Forms.TabControl();
            this.tpPesquisa = new System.Windows.Forms.TabPage();
            this.DgvDados = new System.Windows.Forms.DataGridView();
            this.tpDados = new System.Windows.Forms.TabPage();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnBotoes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbcDados.SuspendLayout();
            this.tpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).BeginInit();
            this.tpDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBotoes
            // 
            this.pnBotoes.Controls.Add(this.BtnExcluir);
            this.pnBotoes.Controls.Add(this.BtnSalvar);
            this.pnBotoes.Controls.Add(this.BtnNovo);
            this.pnBotoes.Controls.Add(this.BtnAbrir);
            this.pnBotoes.Controls.Add(this.BtnCancelar);
            this.pnBotoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(129, 322);
            this.pnBotoes.TabIndex = 1;
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
            // BtnCancelar
            // 
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.Location = new System.Drawing.Point(7, 56);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(117, 46);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvar.Image")));
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvar.Location = new System.Drawing.Point(7, 4);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(117, 46);
            this.BtnSalvar.TabIndex = 2;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNovo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnNovo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNovo.Image")));
            this.BtnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNovo.Location = new System.Drawing.Point(7, 4);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(117, 46);
            this.BtnNovo.TabIndex = 0;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.tbcDados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(129, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 322);
            this.panel1.TabIndex = 4;
            // 
            // tbcDados
            // 
            this.tbcDados.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tbcDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcDados.Controls.Add(this.tpPesquisa);
            this.tbcDados.Controls.Add(this.tpDados);
            this.tbcDados.Location = new System.Drawing.Point(5, 5);
            this.tbcDados.Name = "tbcDados";
            this.tbcDados.Padding = new System.Drawing.Point(50, 3);
            this.tbcDados.SelectedIndex = 0;
            this.tbcDados.Size = new System.Drawing.Size(487, 317);
            this.tbcDados.TabIndex = 0;
            // 
            // tpPesquisa
            // 
            this.tpPesquisa.Controls.Add(this.DgvDados);
            this.tpPesquisa.Location = new System.Drawing.Point(4, 4);
            this.tpPesquisa.Name = "tpPesquisa";
            this.tpPesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tpPesquisa.Size = new System.Drawing.Size(479, 291);
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
            this.DgvDados.Location = new System.Drawing.Point(3, 3);
            this.DgvDados.Name = "DgvDados";
            this.DgvDados.ReadOnly = true;
            this.DgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDados.Size = new System.Drawing.Size(473, 285);
            this.DgvDados.TabIndex = 2;
            this.DgvDados.Text = "dataGridView1";
            this.DgvDados.DoubleClick += new System.EventHandler(this.DgvDados_DoubleClick);
            // 
            // tpDados
            // 
            this.tpDados.Controls.Add(this.textBox8);
            this.tpDados.Controls.Add(this.label7);
            this.tpDados.Controls.Add(this.textBox7);
            this.tpDados.Controls.Add(this.label6);
            this.tpDados.Controls.Add(this.textBox6);
            this.tpDados.Controls.Add(this.label5);
            this.tpDados.Controls.Add(this.textBox5);
            this.tpDados.Controls.Add(this.label4);
            this.tpDados.Controls.Add(this.textBox4);
            this.tpDados.Controls.Add(this.label3);
            this.tpDados.Controls.Add(this.textBox3);
            this.tpDados.Controls.Add(this.label2);
            this.tpDados.Controls.Add(this.textBox2);
            this.tpDados.Controls.Add(this.label1);
            this.tpDados.Controls.Add(this.textBox1);
            this.tpDados.Location = new System.Drawing.Point(4, 4);
            this.tpDados.Name = "tpDados";
            this.tpDados.Padding = new System.Windows.Forms.Padding(3);
            this.tpDados.Size = new System.Drawing.Size(479, 291);
            this.tpDados.TabIndex = 1;
            this.tpDados.Text = "Dados";
            this.tpDados.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(41, 3);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(37, 20);
            this.textBox8.TabIndex = 27;
            this.textBox8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "ODBC";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 146);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(104, 20);
            this.textBox7.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Senha";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(378, 84);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(85, 20);
            this.textBox6.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Usuário";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(286, 84);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(85, 20);
            this.textBox5.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Banco de Dados";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(116, 84);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(164, 20);
            this.textBox4.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Servidor";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(104, 20);
            this.textBox3.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Empresa";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(379, 20);
            this.textBox2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 20);
            this.textBox1.TabIndex = 13;
            // 
            // FrmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 322);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfiguracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.FrmConfiguracoes_Load);
            this.pnBotoes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tbcDados.ResumeLayout(false);
            this.tpPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).EndInit();
            this.tpDados.ResumeLayout(false);
            this.tpDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tpPesquisa;
        protected System.Windows.Forms.Panel pnBotoes;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button BtnNovo;
        protected System.Windows.Forms.TabControl tbcDados;
        protected System.Windows.Forms.Button BtnExcluir;
        protected System.Windows.Forms.Button BtnAbrir;
        protected System.Windows.Forms.DataGridView DgvDados;
        private System.Windows.Forms.TabPage tpDados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        protected System.Windows.Forms.Button BtnCancelar;
        protected System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox textBox8;
    }
}