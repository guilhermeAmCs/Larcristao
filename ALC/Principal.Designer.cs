namespace ALC
{
    partial class frmPrincipal
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
            this.btnCadastrarDoador = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.btnRegistrarDoacao = new System.Windows.Forms.Button();
            this.btnRegistrarRetira = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpCadastro = new System.Windows.Forms.GroupBox();
            this.grpRegistro = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnRelatorioCadastros = new System.Windows.Forms.Button();
            this.btnRelatorioDoacaoRetirada = new System.Windows.Forms.Button();
            this.grpCadastro.SuspendLayout();
            this.grpRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrarDoador
            // 
            this.btnCadastrarDoador.Location = new System.Drawing.Point(38, 36);
            this.btnCadastrarDoador.Name = "btnCadastrarDoador";
            this.btnCadastrarDoador.Size = new System.Drawing.Size(248, 102);
            this.btnCadastrarDoador.TabIndex = 0;
            this.btnCadastrarDoador.Text = "Doador / Parceiro";
            this.btnCadastrarDoador.UseVisualStyleBackColor = true;
            this.btnCadastrarDoador.Click += new System.EventHandler(this.btnCadastrarDoador_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Location = new System.Drawing.Point(38, 165);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(248, 102);
            this.btnCadastrarProduto.TabIndex = 1;
            this.btnCadastrarProduto.Text = "Produto";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // btnRegistrarDoacao
            // 
            this.btnRegistrarDoacao.Location = new System.Drawing.Point(38, 36);
            this.btnRegistrarDoacao.Name = "btnRegistrarDoacao";
            this.btnRegistrarDoacao.Size = new System.Drawing.Size(248, 102);
            this.btnRegistrarDoacao.TabIndex = 2;
            this.btnRegistrarDoacao.Text = "Doação";
            this.btnRegistrarDoacao.UseVisualStyleBackColor = true;
            this.btnRegistrarDoacao.Click += new System.EventHandler(this.btnRegistrarDoacao_Click);
            // 
            // btnRegistrarRetira
            // 
            this.btnRegistrarRetira.Location = new System.Drawing.Point(38, 165);
            this.btnRegistrarRetira.Name = "btnRegistrarRetira";
            this.btnRegistrarRetira.Size = new System.Drawing.Size(248, 102);
            this.btnRegistrarRetira.TabIndex = 3;
            this.btnRegistrarRetira.Text = "Retira";
            this.btnRegistrarRetira.UseVisualStyleBackColor = true;
            this.btnRegistrarRetira.Click += new System.EventHandler(this.btnRegistrarRetira_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(304, 457);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(179, 49);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Fechar Programa";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // grpCadastro
            // 
            this.grpCadastro.Controls.Add(this.btnRelatorioCadastros);
            this.grpCadastro.Controls.Add(this.btnCadastrarProduto);
            this.grpCadastro.Controls.Add(this.btnCadastrarDoador);
            this.grpCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCadastro.Location = new System.Drawing.Point(55, 79);
            this.grpCadastro.Name = "grpCadastro";
            this.grpCadastro.Size = new System.Drawing.Size(321, 346);
            this.grpCadastro.TabIndex = 5;
            this.grpCadastro.TabStop = false;
            this.grpCadastro.Text = "Cadastro";
            // 
            // grpRegistro
            // 
            this.grpRegistro.Controls.Add(this.btnRelatorioDoacaoRetirada);
            this.grpRegistro.Controls.Add(this.btnRegistrarRetira);
            this.grpRegistro.Controls.Add(this.btnRegistrarDoacao);
            this.grpRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegistro.Location = new System.Drawing.Point(410, 79);
            this.grpRegistro.Name = "grpRegistro";
            this.grpRegistro.Size = new System.Drawing.Size(321, 346);
            this.grpRegistro.TabIndex = 6;
            this.grpRegistro.TabStop = false;
            this.grpRegistro.Text = "Registros";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(122, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(542, 31);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Abrigo Lar Cristão - Controle de Estoque";
            // 
            // btnRelatorioCadastros
            // 
            this.btnRelatorioCadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioCadastros.Location = new System.Drawing.Point(38, 292);
            this.btnRelatorioCadastros.Name = "btnRelatorioCadastros";
            this.btnRelatorioCadastros.Size = new System.Drawing.Size(248, 38);
            this.btnRelatorioCadastros.TabIndex = 2;
            this.btnRelatorioCadastros.Text = "Consultar Doadores / Produto";
            this.btnRelatorioCadastros.UseVisualStyleBackColor = true;
            this.btnRelatorioCadastros.Click += new System.EventHandler(this.btnRelatorioCadastros_Click);
            // 
            // btnRelatorioDoacaoRetirada
            // 
            this.btnRelatorioDoacaoRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorioDoacaoRetirada.Location = new System.Drawing.Point(38, 292);
            this.btnRelatorioDoacaoRetirada.Name = "btnRelatorioDoacaoRetirada";
            this.btnRelatorioDoacaoRetirada.Size = new System.Drawing.Size(248, 38);
            this.btnRelatorioDoacaoRetirada.TabIndex = 4;
            this.btnRelatorioDoacaoRetirada.Text = "Relatório de Doações / Retiras";
            this.btnRelatorioDoacaoRetirada.UseVisualStyleBackColor = true;
            this.btnRelatorioDoacaoRetirada.Click += new System.EventHandler(this.btnRelatorioDoacaoRetirada_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 519);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grpRegistro);
            this.Controls.Add(this.grpCadastro);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estoque";
            this.grpCadastro.ResumeLayout(false);
            this.grpRegistro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarDoador;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Button btnRegistrarDoacao;
        private System.Windows.Forms.Button btnRegistrarRetira;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox grpCadastro;
        private System.Windows.Forms.GroupBox grpRegistro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRelatorioCadastros;
        private System.Windows.Forms.Button btnRelatorioDoacaoRetirada;
    }
}

