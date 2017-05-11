namespace ALC
{
    partial class RegistroRetira
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
            this.lblRetira = new System.Windows.Forms.Label();
            this.grbDescProduto = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.cmbDescricao = new System.Windows.Forms.ComboBox();
            this.lblTipoProduto = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblDescricaoProduto = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCasa = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grbDescProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRetira
            // 
            this.lblRetira.AutoSize = true;
            this.lblRetira.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetira.Location = new System.Drawing.Point(183, 10);
            this.lblRetira.Name = "lblRetira";
            this.lblRetira.Size = new System.Drawing.Size(245, 31);
            this.lblRetira.TabIndex = 9;
            this.lblRetira.Text = "Retira de Material";
            // 
            // grbDescProduto
            // 
            this.grbDescProduto.Controls.Add(this.comboBox1);
            this.grbDescProduto.Controls.Add(this.lblCasa);
            this.grbDescProduto.Controls.Add(this.numericUpDown1);
            this.grbDescProduto.Controls.Add(this.lblQuantidade);
            this.grbDescProduto.Controls.Add(this.cmbDescricao);
            this.grbDescProduto.Controls.Add(this.lblTipoProduto);
            this.grbDescProduto.Controls.Add(this.cmbTipo);
            this.grbDescProduto.Controls.Add(this.lblDescricaoProduto);
            this.grbDescProduto.Location = new System.Drawing.Point(20, 54);
            this.grbDescProduto.Name = "grbDescProduto";
            this.grbDescProduto.Size = new System.Drawing.Size(571, 202);
            this.grbDescProduto.TabIndex = 21;
            this.grbDescProduto.TabStop = false;
            this.grbDescProduto.Text = "Selecione a Casa / Tipo do Produto / Descrição  / Quantidade";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(245, 156);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(305, 20);
            this.numericUpDown1.TabIndex = 26;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Enabled = false;
            this.lblQuantidade.Location = new System.Drawing.Point(20, 160);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(203, 13);
            this.lblQuantidade.TabIndex = 25;
            this.lblQuantidade.Text = "Informe a quantidade solicitada pela casa";
            // 
            // cmbDescricao
            // 
            this.cmbDescricao.Enabled = false;
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
            this.cmbDescricao.Location = new System.Drawing.Point(176, 117);
            this.cmbDescricao.Name = "cmbDescricao";
            this.cmbDescricao.Size = new System.Drawing.Size(374, 21);
            this.cmbDescricao.TabIndex = 24;
            this.cmbDescricao.Text = "Clique aqui para selecionar a descrição do produto ...";
            this.cmbDescricao.SelectedIndexChanged += new System.EventHandler(this.cmbDescricao_SelectedIndexChanged);
            // 
            // lblTipoProduto
            // 
            this.lblTipoProduto.AutoSize = true;
            this.lblTipoProduto.Enabled = false;
            this.lblTipoProduto.Location = new System.Drawing.Point(20, 80);
            this.lblTipoProduto.Name = "lblTipoProduto";
            this.lblTipoProduto.Size = new System.Drawing.Size(137, 13);
            this.lblTipoProduto.TabIndex = 13;
            this.lblTipoProduto.Text = "Selecione o tipo do produto";
            // 
            // cmbTipo
            // 
            this.cmbTipo.Enabled = false;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Brinquedo",
            "Alimento",
            "Roupa"});
            this.cmbTipo.Location = new System.Drawing.Point(176, 77);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(374, 21);
            this.cmbTipo.TabIndex = 23;
            this.cmbTipo.Text = "Clique aqui para selecionar o tipo do produto ...";
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.AutoSize = true;
            this.lblDescricaoProduto.Enabled = false;
            this.lblDescricaoProduto.Location = new System.Drawing.Point(20, 120);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(112, 13);
            this.lblDescricaoProduto.TabIndex = 14;
            this.lblDescricaoProduto.Text = "Selecione a descrição";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(20, 281);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(143, 36);
            this.btnVoltar.TabIndex = 26;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(234, 281);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(143, 36);
            this.btnLimpar.TabIndex = 25;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(448, 281);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(143, 36);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblCasa
            // 
            this.lblCasa.AutoSize = true;
            this.lblCasa.Location = new System.Drawing.Point(25, 40);
            this.lblCasa.Name = "lblCasa";
            this.lblCasa.Size = new System.Drawing.Size(89, 13);
            this.lblCasa.TabIndex = 27;
            this.lblCasa.Text = "Selecione a casa";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Casa Emanuel",
            "Casa Hosana",
            "Casa Esqueci o nome"});
            this.comboBox1.Location = new System.Drawing.Point(176, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(374, 21);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.Text = "Clique aqui para selecionar a casa que fez a requisição ...";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RegistroRetira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 332);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grbDescProduto);
            this.Controls.Add(this.lblRetira);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistroRetira";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de retirada de material";
            this.grbDescProduto.ResumeLayout(false);
            this.grbDescProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRetira;
        private System.Windows.Forms.GroupBox grbDescProduto;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.ComboBox cmbDescricao;
        private System.Windows.Forms.Label lblTipoProduto;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblDescricaoProduto;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCasa;
    }
}