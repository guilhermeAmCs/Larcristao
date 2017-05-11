namespace ALC
{
    partial class CadastroProduto
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
            this.grbTipo = new System.Windows.Forms.GroupBox();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.grbIncluirTipo = new System.Windows.Forms.GroupBox();
            this.lblNovoTipo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txbNovoTipo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCadastroProduto = new System.Windows.Forms.Label();
            this.grbTipo.SuspendLayout();
            this.grbIncluirTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTipo
            // 
            this.grbTipo.Controls.Add(this.btnConcluir);
            this.grbTipo.Controls.Add(this.btnCadastrar);
            this.grbTipo.Controls.Add(this.txbDescricao);
            this.grbTipo.Controls.Add(this.cmbTipo);
            this.grbTipo.Controls.Add(this.lblDescricao);
            this.grbTipo.Controls.Add(this.lblTipo);
            this.grbTipo.Controls.Add(this.grbIncluirTipo);
            this.grbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTipo.Location = new System.Drawing.Point(15, 68);
            this.grbTipo.Name = "grbTipo";
            this.grbTipo.Size = new System.Drawing.Size(628, 213);
            this.grbTipo.TabIndex = 0;
            this.grbTipo.TabStop = false;
            this.grbTipo.Text = "Tipo de Produto";
            // 
            // btnConcluir
            // 
            this.btnConcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.Location = new System.Drawing.Point(472, 161);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(143, 36);
            this.btnConcluir.TabIndex = 10;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(16, 161);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(239, 36);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar Produto";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // txbDescricao
            // 
            this.txbDescricao.Enabled = false;
            this.txbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescricao.Location = new System.Drawing.Point(16, 123);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(239, 20);
            this.txbDescricao.TabIndex = 12;
            this.txbDescricao.TextChanged += new System.EventHandler(this.txbDescricao_TextChanged);
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Novo ( cadastrar tipo ainda não existente )",
            "BRINQUEDO",
            "ROUPA"});
            this.cmbTipo.Location = new System.Drawing.Point(16, 58);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(239, 21);
            this.cmbTipo.TabIndex = 10;
            this.cmbTipo.Text = "Clique aqui para selecionar um tipo ...";
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Enabled = false;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(13, 98);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(228, 13);
            this.lblDescricao.TabIndex = 11;
            this.lblDescricao.Text = "Digite a descrição do produto a ser cadastrado";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(13, 37);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(242, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Selecione o tipo do produto que deseja cadastrar:";
            // 
            // grbIncluirTipo
            // 
            this.grbIncluirTipo.Controls.Add(this.lblNovoTipo);
            this.grbIncluirTipo.Controls.Add(this.btnLimpar);
            this.grbIncluirTipo.Controls.Add(this.txbNovoTipo);
            this.grbIncluirTipo.Controls.Add(this.btnSalvar);
            this.grbIncluirTipo.Enabled = false;
            this.grbIncluirTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbIncluirTipo.Location = new System.Drawing.Point(276, 12);
            this.grbIncluirTipo.Name = "grbIncluirTipo";
            this.grbIncluirTipo.Size = new System.Drawing.Size(339, 88);
            this.grbIncluirTipo.TabIndex = 1;
            this.grbIncluirTipo.TabStop = false;
            this.grbIncluirTipo.Text = "Cadastrar Novo Tipo";
            // 
            // lblNovoTipo
            // 
            this.lblNovoTipo.AutoSize = true;
            this.lblNovoTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoTipo.Location = new System.Drawing.Point(13, 25);
            this.lblNovoTipo.Name = "lblNovoTipo";
            this.lblNovoTipo.Size = new System.Drawing.Size(154, 13);
            this.lblNovoTipo.TabIndex = 13;
            this.lblNovoTipo.Text = "Digite a descrição do novo tipo";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(16, 55);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(102, 20);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txbNovoTipo
            // 
            this.txbNovoTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNovoTipo.Location = new System.Drawing.Point(173, 22);
            this.txbNovoTipo.Name = "txbNovoTipo";
            this.txbNovoTipo.Size = new System.Drawing.Size(153, 20);
            this.txbNovoTipo.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(224, 55);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 20);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblCadastroProduto
            // 
            this.lblCadastroProduto.AutoSize = true;
            this.lblCadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroProduto.Location = new System.Drawing.Point(110, 19);
            this.lblCadastroProduto.Name = "lblCadastroProduto";
            this.lblCadastroProduto.Size = new System.Drawing.Size(439, 31);
            this.lblCadastroProduto.TabIndex = 9;
            this.lblCadastroProduto.Text = "Cadastro de Produto / Descrição";
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 296);
            this.ControlBox = false;
            this.Controls.Add(this.lblCadastroProduto);
            this.Controls.Add(this.grbTipo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroProduto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produto / Descrição";
            this.grbTipo.ResumeLayout(false);
            this.grbTipo.PerformLayout();
            this.grbIncluirTipo.ResumeLayout(false);
            this.grbIncluirTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTipo;
        private System.Windows.Forms.GroupBox grbIncluirTipo;
        private System.Windows.Forms.Label lblCadastroProduto;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txbNovoTipo;
        private System.Windows.Forms.Label lblNovoTipo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnConcluir;
    }
}