namespace ALC
{
    partial class RelatorioCadastro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCadastroDoador = new System.Windows.Forms.Label();
            this.grbDoadores = new System.Windows.Forms.GroupBox();
            this.grbProdutos = new System.Windows.Forms.GroupBox();
            this.btnPDFproduto = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnRelatorioGeral = new System.Windows.Forms.Button();
            this.lblConsultaCPF = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TelefoneCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.lblConsultaCNPJ = new System.Windows.Forms.Label();
            this.btnPDFcnpj = new System.Windows.Forms.Button();
            this.btnPDFcpf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.grbDoadores.SuspendLayout();
            this.grbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Descricao,
            this.Quantidade});
            this.dataGridView2.Location = new System.Drawing.Point(15, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(503, 105);
            this.dataGridView2.TabIndex = 3;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo do Produto";
            this.Tipo.Name = "Tipo";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição do Produto";
            this.Descricao.Name = "Descricao";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // lblCadastroDoador
            // 
            this.lblCadastroDoador.AutoSize = true;
            this.lblCadastroDoador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroDoador.Location = new System.Drawing.Point(124, 20);
            this.lblCadastroDoador.Name = "lblCadastroDoador";
            this.lblCadastroDoador.Size = new System.Drawing.Size(401, 31);
            this.lblCadastroDoador.TabIndex = 9;
            this.lblCadastroDoador.Text = "Consultar Doadores / Produto";
            // 
            // grbDoadores
            // 
            this.grbDoadores.Controls.Add(this.btnPDFcpf);
            this.grbDoadores.Controls.Add(this.btnPDFcnpj);
            this.grbDoadores.Controls.Add(this.lblConsultaCNPJ);
            this.grbDoadores.Controls.Add(this.dataGridView3);
            this.grbDoadores.Controls.Add(this.dataGridView1);
            this.grbDoadores.Controls.Add(this.lblConsultaCPF);
            this.grbDoadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDoadores.Location = new System.Drawing.Point(13, 69);
            this.grbDoadores.Name = "grbDoadores";
            this.grbDoadores.Size = new System.Drawing.Size(622, 312);
            this.grbDoadores.TabIndex = 10;
            this.grbDoadores.TabStop = false;
            this.grbDoadores.Text = "Relação dos doadores / parceiros cadastrados";
            // 
            // grbProdutos
            // 
            this.grbProdutos.Controls.Add(this.btnPDFproduto);
            this.grbProdutos.Controls.Add(this.dataGridView2);
            this.grbProdutos.Location = new System.Drawing.Point(13, 397);
            this.grbProdutos.Name = "grbProdutos";
            this.grbProdutos.Size = new System.Drawing.Size(622, 150);
            this.grbProdutos.TabIndex = 11;
            this.grbProdutos.TabStop = false;
            this.grbProdutos.Text = "Relação dos Produtos cadastrados";
            // 
            // btnPDFproduto
            // 
            this.btnPDFproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDFproduto.Location = new System.Drawing.Point(524, 23);
            this.btnPDFproduto.Name = "btnPDFproduto";
            this.btnPDFproduto.Size = new System.Drawing.Size(92, 105);
            this.btnPDFproduto.TabIndex = 12;
            this.btnPDFproduto.Text = "Imprimir\r\n\r\nProdutos";
            this.btnPDFproduto.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(24, 565);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(143, 36);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnRelatorioGeral
            // 
            this.btnRelatorioGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioGeral.Location = new System.Drawing.Point(331, 565);
            this.btnRelatorioGeral.Name = "btnRelatorioGeral";
            this.btnRelatorioGeral.Size = new System.Drawing.Size(294, 36);
            this.btnRelatorioGeral.TabIndex = 13;
            this.btnRelatorioGeral.Text = "Imprimir Relatório Completo";
            this.btnRelatorioGeral.UseVisualStyleBackColor = true;
            this.btnRelatorioGeral.Click += new System.EventHandler(this.btnRelatorioGeral_Click);
            // 
            // lblConsultaCPF
            // 
            this.lblConsultaCPF.AutoSize = true;
            this.lblConsultaCPF.Location = new System.Drawing.Point(12, 162);
            this.lblConsultaCPF.Name = "lblConsultaCPF";
            this.lblConsultaCPF.Size = new System.Drawing.Size(109, 13);
            this.lblConsultaCPF.TabIndex = 1;
            this.lblConsultaCPF.Text = "Pessoa Física ( CPF )";
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "E-Mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Contato";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Razao
            // 
            this.Razao.HeaderText = "Razão Social";
            this.Razao.Name = "Razao";
            this.Razao.ReadOnly = true;
            // 
            // CNPJ
            // 
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNPJ,
            this.Razao,
            this.Nome,
            this.Email,
            this.Telefone});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(15, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(503, 105);
            this.dataGridView1.TabIndex = 0;
            // 
            // TelefoneCPF
            // 
            this.TelefoneCPF.HeaderText = "Telefone";
            this.TelefoneCPF.Name = "TelefoneCPF";
            // 
            // EmailCPF
            // 
            this.EmailCPF.HeaderText = "E-Mail";
            this.EmailCPF.Name = "EmailCPF";
            // 
            // NomeCPF
            // 
            this.NomeCPF.HeaderText = "Nome";
            this.NomeCPF.Name = "NomeCPF";
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // dataGridView3
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPF,
            this.NomeCPF,
            this.EmailCPF,
            this.TelefoneCPF});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView3.Location = new System.Drawing.Point(15, 182);
            this.dataGridView3.Name = "dataGridView3";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView3.Size = new System.Drawing.Size(503, 105);
            this.dataGridView3.TabIndex = 1;
            // 
            // lblConsultaCNPJ
            // 
            this.lblConsultaCNPJ.AutoSize = true;
            this.lblConsultaCNPJ.Location = new System.Drawing.Point(12, 25);
            this.lblConsultaCNPJ.Name = "lblConsultaCNPJ";
            this.lblConsultaCNPJ.Size = new System.Drawing.Size(95, 13);
            this.lblConsultaCNPJ.TabIndex = 12;
            this.lblConsultaCNPJ.Text = "Empresas ( CNPJ )";
            // 
            // btnPDFcnpj
            // 
            this.btnPDFcnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDFcnpj.Location = new System.Drawing.Point(524, 46);
            this.btnPDFcnpj.Name = "btnPDFcnpj";
            this.btnPDFcnpj.Size = new System.Drawing.Size(92, 105);
            this.btnPDFcnpj.TabIndex = 13;
            this.btnPDFcnpj.Text = "Imprimir\r\n\r\nRelação CNPJ";
            this.btnPDFcnpj.UseVisualStyleBackColor = true;
            // 
            // btnPDFcpf
            // 
            this.btnPDFcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDFcpf.Location = new System.Drawing.Point(524, 182);
            this.btnPDFcpf.Name = "btnPDFcpf";
            this.btnPDFcpf.Size = new System.Drawing.Size(92, 105);
            this.btnPDFcpf.TabIndex = 14;
            this.btnPDFcpf.Text = "Imprimir\r\n\r\nRelação CPF";
            this.btnPDFcpf.UseVisualStyleBackColor = true;
            // 
            // RelatorioCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 621);
            this.ControlBox = false;
            this.Controls.Add(this.btnRelatorioGeral);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblCadastroDoador);
            this.Controls.Add(this.grbDoadores);
            this.Controls.Add(this.grbProdutos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RelatorioCadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Doadores / Produto - Relatórios impressos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.grbDoadores.ResumeLayout(false);
            this.grbDoadores.PerformLayout();
            this.grbProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblCadastroDoador;
        private System.Windows.Forms.GroupBox grbDoadores;
        private System.Windows.Forms.GroupBox grbProdutos;
        private System.Windows.Forms.Button btnPDFproduto;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnRelatorioGeral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.Button btnPDFcpf;
        private System.Windows.Forms.Button btnPDFcnpj;
        private System.Windows.Forms.Label lblConsultaCNPJ;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneCPF;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.Label lblConsultaCPF;
    }
}