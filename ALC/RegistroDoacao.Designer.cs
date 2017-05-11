namespace ALC
{
    partial class RegistroDoacao
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
            this.lblDoacao = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTipoProduto = new System.Windows.Forms.Label();
            this.lblDescricaoProduto = new System.Windows.Forms.Label();
            this.rdbCNPJ = new System.Windows.Forms.RadioButton();
            this.rdbCPF = new System.Windows.Forms.RadioButton();
            this.rdbOutros = new System.Windows.Forms.RadioButton();
            this.grbTipoDoador = new System.Windows.Forms.GroupBox();
            this.grbDescDoador = new System.Windows.Forms.GroupBox();
            this.cmbPessoa = new System.Windows.Forms.ComboBox();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.grbDescProduto = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.cmbDescricao = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grbTipoDoador.SuspendLayout();
            this.grbDescDoador.SuspendLayout();
            this.grbDescProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDoacao
            // 
            this.lblDoacao.AutoSize = true;
            this.lblDoacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoacao.Location = new System.Drawing.Point(347, 27);
            this.lblDoacao.Name = "lblDoacao";
            this.lblDoacao.Size = new System.Drawing.Size(242, 31);
            this.lblDoacao.TabIndex = 9;
            this.lblDoacao.Text = "Registrar Doação";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(20, 31);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(150, 13);
            this.lblCNPJ.TabIndex = 11;
            this.lblCNPJ.Text = "Selecione o nome da empresa";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(20, 71);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(144, 13);
            this.lblCPF.TabIndex = 12;
            this.lblCPF.Text = "Selecione o nome da pessoa";
            // 
            // lblTipoProduto
            // 
            this.lblTipoProduto.AutoSize = true;
            this.lblTipoProduto.Location = new System.Drawing.Point(20, 30);
            this.lblTipoProduto.Name = "lblTipoProduto";
            this.lblTipoProduto.Size = new System.Drawing.Size(137, 13);
            this.lblTipoProduto.TabIndex = 13;
            this.lblTipoProduto.Text = "Selecione o tipo do produto";
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.AutoSize = true;
            this.lblDescricaoProduto.Location = new System.Drawing.Point(20, 71);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(112, 13);
            this.lblDescricaoProduto.TabIndex = 14;
            this.lblDescricaoProduto.Text = "Selecione a descrição";
            // 
            // rdbCNPJ
            // 
            this.rdbCNPJ.AutoSize = true;
            this.rdbCNPJ.Location = new System.Drawing.Point(21, 21);
            this.rdbCNPJ.Name = "rdbCNPJ";
            this.rdbCNPJ.Size = new System.Drawing.Size(52, 17);
            this.rdbCNPJ.TabIndex = 15;
            this.rdbCNPJ.Text = "CNPJ";
            this.rdbCNPJ.UseVisualStyleBackColor = true;
            this.rdbCNPJ.Click += new System.EventHandler(this.rdbCNPJ_Click);
            // 
            // rdbCPF
            // 
            this.rdbCPF.AutoSize = true;
            this.rdbCPF.Location = new System.Drawing.Point(97, 21);
            this.rdbCPF.Name = "rdbCPF";
            this.rdbCPF.Size = new System.Drawing.Size(45, 17);
            this.rdbCPF.TabIndex = 16;
            this.rdbCPF.Text = "CPF";
            this.rdbCPF.UseVisualStyleBackColor = true;
            this.rdbCPF.Click += new System.EventHandler(this.rdbCPF_Click);
            // 
            // rdbOutros
            // 
            this.rdbOutros.AutoSize = true;
            this.rdbOutros.Location = new System.Drawing.Point(166, 21);
            this.rdbOutros.Name = "rdbOutros";
            this.rdbOutros.Size = new System.Drawing.Size(56, 17);
            this.rdbOutros.TabIndex = 17;
            this.rdbOutros.Text = "Outros";
            this.rdbOutros.UseVisualStyleBackColor = true;
            this.rdbOutros.Click += new System.EventHandler(this.rdbOutros_Click);
            // 
            // grbTipoDoador
            // 
            this.grbTipoDoador.Controls.Add(this.rdbOutros);
            this.grbTipoDoador.Controls.Add(this.rdbCNPJ);
            this.grbTipoDoador.Controls.Add(this.rdbCPF);
            this.grbTipoDoador.Location = new System.Drawing.Point(18, 20);
            this.grbTipoDoador.Name = "grbTipoDoador";
            this.grbTipoDoador.Size = new System.Drawing.Size(243, 51);
            this.grbTipoDoador.TabIndex = 18;
            this.grbTipoDoador.TabStop = false;
            this.grbTipoDoador.Text = "Doador";
            // 
            // grbDescDoador
            // 
            this.grbDescDoador.Controls.Add(this.cmbPessoa);
            this.grbDescDoador.Controls.Add(this.cmbEmpresa);
            this.grbDescDoador.Controls.Add(this.lblCNPJ);
            this.grbDescDoador.Controls.Add(this.lblCPF);
            this.grbDescDoador.Enabled = false;
            this.grbDescDoador.Location = new System.Drawing.Point(18, 82);
            this.grbDescDoador.Name = "grbDescDoador";
            this.grbDescDoador.Size = new System.Drawing.Size(571, 108);
            this.grbDescDoador.TabIndex = 19;
            this.grbDescDoador.TabStop = false;
            this.grbDescDoador.Text = "Selecione a Empresa ou Pessoa";
            // 
            // cmbPessoa
            // 
            this.cmbPessoa.FormattingEnabled = true;
            this.cmbPessoa.Items.AddRange(new object[] {
            "Cleyton",
            "Leandro",
            "Guilherme",
            "Tobias"});
            this.cmbPessoa.Location = new System.Drawing.Point(176, 68);
            this.cmbPessoa.Name = "cmbPessoa";
            this.cmbPessoa.Size = new System.Drawing.Size(374, 21);
            this.cmbPessoa.TabIndex = 22;
            this.cmbPessoa.Text = "Clique aqui para selecionar a pessoa ...";
            this.cmbPessoa.SelectedIndexChanged += new System.EventHandler(this.cmbPessoa_SelectedIndexChanged);
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Items.AddRange(new object[] {
            "EPA Supermercado",
            "CEASA",
            "Empresa de Teste 1"});
            this.cmbEmpresa.Location = new System.Drawing.Point(176, 28);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(374, 21);
            this.cmbEmpresa.TabIndex = 21;
            this.cmbEmpresa.Text = "Clique aqui para selecionar a empresa ...";
            this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_SelectedIndexChanged);
            // 
            // grbDescProduto
            // 
            this.grbDescProduto.Controls.Add(this.numericUpDown1);
            this.grbDescProduto.Controls.Add(this.lblQuantidade);
            this.grbDescProduto.Controls.Add(this.cmbDescricao);
            this.grbDescProduto.Controls.Add(this.lblTipoProduto);
            this.grbDescProduto.Controls.Add(this.cmbTipo);
            this.grbDescProduto.Controls.Add(this.lblDescricaoProduto);
            this.grbDescProduto.Enabled = false;
            this.grbDescProduto.Location = new System.Drawing.Point(18, 206);
            this.grbDescProduto.Name = "grbDescProduto";
            this.grbDescProduto.Size = new System.Drawing.Size(571, 146);
            this.grbDescProduto.TabIndex = 20;
            this.grbDescProduto.TabStop = false;
            this.grbDescProduto.Text = "Selecione o Tipo do Produto / Descrição ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(245, 107);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 26;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(20, 112);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(208, 13);
            this.lblQuantidade.TabIndex = 25;
            this.lblQuantidade.Text = "Informe a quantidade doada deste produto";
            // 
            // cmbDescricao
            // 
            this.cmbDescricao.FormattingEnabled = true;
            this.cmbDescricao.Items.AddRange(new object[] {
            "PlayStation 4",
            "PlayStation 5",
            "Lego - StarWars",
            "Comida gostosa",
            "Comida gostosa não perecivel",
            "Roupa de frio",
            "Camiseta",
            "Outro produto qualquer"});
            this.cmbDescricao.Location = new System.Drawing.Point(176, 68);
            this.cmbDescricao.Name = "cmbDescricao";
            this.cmbDescricao.Size = new System.Drawing.Size(374, 21);
            this.cmbDescricao.TabIndex = 24;
            this.cmbDescricao.Text = "Clique aqui para selecionar a descrição do produto ...";
            this.cmbDescricao.SelectedIndexChanged += new System.EventHandler(this.cmbDescricao_SelectedIndexChanged);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Brinquedo",
            "Alimento",
            "Roupa"});
            this.cmbTipo.Location = new System.Drawing.Point(176, 27);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(374, 21);
            this.cmbTipo.TabIndex = 23;
            this.cmbTipo.Text = "Clique aqui para selecionar o tipo do produto ...";
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(18, 374);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(143, 36);
            this.btnVoltar.TabIndex = 23;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(232, 374);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(143, 36);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(446, 374);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(143, 36);
            this.btnSalvar.TabIndex = 21;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // RegistroDoacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 431);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grbDescProduto);
            this.Controls.Add(this.lblDoacao);
            this.Controls.Add(this.grbTipoDoador);
            this.Controls.Add(this.grbDescDoador);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistroDoacao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Doações";
            this.grbTipoDoador.ResumeLayout(false);
            this.grbTipoDoador.PerformLayout();
            this.grbDescDoador.ResumeLayout(false);
            this.grbDescDoador.PerformLayout();
            this.grbDescProduto.ResumeLayout(false);
            this.grbDescProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoacao;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTipoProduto;
        private System.Windows.Forms.Label lblDescricaoProduto;
        private System.Windows.Forms.RadioButton rdbCNPJ;
        private System.Windows.Forms.RadioButton rdbCPF;
        private System.Windows.Forms.RadioButton rdbOutros;
        private System.Windows.Forms.GroupBox grbTipoDoador;
        private System.Windows.Forms.GroupBox grbDescDoador;
        private System.Windows.Forms.GroupBox grbDescProduto;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.ComboBox cmbPessoa;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbDescricao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblQuantidade;
    }
}