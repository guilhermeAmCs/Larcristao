namespace ALC
{
    partial class CadastroDador
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
            this.rdbCNPJ = new System.Windows.Forms.RadioButton();
            this.rdbCPF = new System.Windows.Forms.RadioButton();
            this.grbCNPJ = new System.Windows.Forms.GroupBox();
            this.txbEmailcnpj = new System.Windows.Forms.TextBox();
            this.txbTelefone2cnpj = new System.Windows.Forms.TextBox();
            this.txbTelefone1cnpj = new System.Windows.Forms.TextBox();
            this.txbContato = new System.Windows.Forms.TextBox();
            this.txbRazao = new System.Windows.Forms.TextBox();
            this.txbCNPJ = new System.Windows.Forms.TextBox();
            this.lblEmailcnpj = new System.Windows.Forms.Label();
            this.lblTelefone2cnpj = new System.Windows.Forms.Label();
            this.lblTelefone1cnpj = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.lblRazao = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.grbCPF = new System.Windows.Forms.GroupBox();
            this.txbEmailcpf = new System.Windows.Forms.TextBox();
            this.txbTelefone2cpf = new System.Windows.Forms.TextBox();
            this.txbTelefone1cpf = new System.Windows.Forms.TextBox();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblEmailcpf = new System.Windows.Forms.Label();
            this.lblTelefone2cpf = new System.Windows.Forms.Label();
            this.lblTelefone1cpf = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.grbTipo = new System.Windows.Forms.GroupBox();
            this.lblCadastroDoador = new System.Windows.Forms.Label();
            this.grbCNPJ.SuspendLayout();
            this.grbCPF.SuspendLayout();
            this.grbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbCNPJ
            // 
            this.rdbCNPJ.AutoSize = true;
            this.rdbCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCNPJ.Location = new System.Drawing.Point(18, 18);
            this.rdbCNPJ.Name = "rdbCNPJ";
            this.rdbCNPJ.Size = new System.Drawing.Size(52, 17);
            this.rdbCNPJ.TabIndex = 0;
            this.rdbCNPJ.TabStop = true;
            this.rdbCNPJ.Text = "CNPJ";
            this.rdbCNPJ.UseVisualStyleBackColor = true;
            this.rdbCNPJ.Click += new System.EventHandler(this.rdbCNPJ_Click);
            // 
            // rdbCPF
            // 
            this.rdbCPF.AutoSize = true;
            this.rdbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCPF.Location = new System.Drawing.Point(104, 18);
            this.rdbCPF.Name = "rdbCPF";
            this.rdbCPF.Size = new System.Drawing.Size(45, 17);
            this.rdbCPF.TabIndex = 1;
            this.rdbCPF.TabStop = true;
            this.rdbCPF.Text = "CPF";
            this.rdbCPF.UseVisualStyleBackColor = true;
            this.rdbCPF.Click += new System.EventHandler(this.rdbCPF_Click);
            // 
            // grbCNPJ
            // 
            this.grbCNPJ.Controls.Add(this.txbEmailcnpj);
            this.grbCNPJ.Controls.Add(this.txbTelefone2cnpj);
            this.grbCNPJ.Controls.Add(this.txbTelefone1cnpj);
            this.grbCNPJ.Controls.Add(this.txbContato);
            this.grbCNPJ.Controls.Add(this.txbRazao);
            this.grbCNPJ.Controls.Add(this.txbCNPJ);
            this.grbCNPJ.Controls.Add(this.lblEmailcnpj);
            this.grbCNPJ.Controls.Add(this.lblTelefone2cnpj);
            this.grbCNPJ.Controls.Add(this.lblTelefone1cnpj);
            this.grbCNPJ.Controls.Add(this.lblContato);
            this.grbCNPJ.Controls.Add(this.lblRazao);
            this.grbCNPJ.Controls.Add(this.lblCNPJ);
            this.grbCNPJ.Enabled = false;
            this.grbCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCNPJ.Location = new System.Drawing.Point(12, 63);
            this.grbCNPJ.Name = "grbCNPJ";
            this.grbCNPJ.Size = new System.Drawing.Size(756, 202);
            this.grbCNPJ.TabIndex = 2;
            this.grbCNPJ.TabStop = false;
            this.grbCNPJ.Text = "CNPJ";
            // 
            // txbEmailcnpj
            // 
            this.txbEmailcnpj.Location = new System.Drawing.Point(208, 159);
            this.txbEmailcnpj.Name = "txbEmailcnpj";
            this.txbEmailcnpj.Size = new System.Drawing.Size(235, 20);
            this.txbEmailcnpj.TabIndex = 12;
            this.txbEmailcnpj.TextChanged += new System.EventHandler(this.txbEmailcnpj_TextChanged);
            // 
            // txbTelefone2cnpj
            // 
            this.txbTelefone2cnpj.Location = new System.Drawing.Point(456, 129);
            this.txbTelefone2cnpj.Name = "txbTelefone2cnpj";
            this.txbTelefone2cnpj.Size = new System.Drawing.Size(182, 20);
            this.txbTelefone2cnpj.TabIndex = 11;
            this.txbTelefone2cnpj.TextChanged += new System.EventHandler(this.txbTelefone2cnpj_TextChanged);
            // 
            // txbTelefone1cnpj
            // 
            this.txbTelefone1cnpj.Location = new System.Drawing.Point(456, 94);
            this.txbTelefone1cnpj.Name = "txbTelefone1cnpj";
            this.txbTelefone1cnpj.Size = new System.Drawing.Size(182, 20);
            this.txbTelefone1cnpj.TabIndex = 10;
            this.txbTelefone1cnpj.TextChanged += new System.EventHandler(this.txbTelefone1cnpj_TextChanged);
            // 
            // txbContato
            // 
            this.txbContato.Location = new System.Drawing.Point(208, 94);
            this.txbContato.Name = "txbContato";
            this.txbContato.Size = new System.Drawing.Size(149, 20);
            this.txbContato.TabIndex = 9;
            this.txbContato.TextChanged += new System.EventHandler(this.txbContato_TextChanged);
            // 
            // txbRazao
            // 
            this.txbRazao.Location = new System.Drawing.Point(208, 56);
            this.txbRazao.Name = "txbRazao";
            this.txbRazao.Size = new System.Drawing.Size(430, 20);
            this.txbRazao.TabIndex = 8;
            this.txbRazao.TextChanged += new System.EventHandler(this.txbRazao_TextChanged);
            // 
            // txbCNPJ
            // 
            this.txbCNPJ.Location = new System.Drawing.Point(208, 24);
            this.txbCNPJ.Name = "txbCNPJ";
            this.txbCNPJ.Size = new System.Drawing.Size(235, 20);
            this.txbCNPJ.TabIndex = 7;
            this.txbCNPJ.TextChanged += new System.EventHandler(this.txbCNPJ_TextChanged);
            // 
            // lblEmailcnpj
            // 
            this.lblEmailcnpj.AutoSize = true;
            this.lblEmailcnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailcnpj.Location = new System.Drawing.Point(118, 162);
            this.lblEmailcnpj.Name = "lblEmailcnpj";
            this.lblEmailcnpj.Size = new System.Drawing.Size(35, 13);
            this.lblEmailcnpj.TabIndex = 5;
            this.lblEmailcnpj.Text = "E-mail";
            // 
            // lblTelefone2cnpj
            // 
            this.lblTelefone2cnpj.AutoSize = true;
            this.lblTelefone2cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone2cnpj.Location = new System.Drawing.Point(401, 132);
            this.lblTelefone2cnpj.Name = "lblTelefone2cnpj";
            this.lblTelefone2cnpj.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone2cnpj.TabIndex = 4;
            this.lblTelefone2cnpj.Text = "Telefone";
            // 
            // lblTelefone1cnpj
            // 
            this.lblTelefone1cnpj.AutoSize = true;
            this.lblTelefone1cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone1cnpj.Location = new System.Drawing.Point(401, 97);
            this.lblTelefone1cnpj.Name = "lblTelefone1cnpj";
            this.lblTelefone1cnpj.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone1cnpj.TabIndex = 3;
            this.lblTelefone1cnpj.Text = "Telefone";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.Location = new System.Drawing.Point(118, 97);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(83, 13);
            this.lblContato.TabIndex = 2;
            this.lblContato.Text = "Nome / Contato";
            // 
            // lblRazao
            // 
            this.lblRazao.AutoSize = true;
            this.lblRazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazao.Location = new System.Drawing.Point(118, 59);
            this.lblRazao.Name = "lblRazao";
            this.lblRazao.Size = new System.Drawing.Size(70, 13);
            this.lblRazao.TabIndex = 1;
            this.lblRazao.Text = "Razão Social";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(118, 27);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblCNPJ.TabIndex = 0;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // grbCPF
            // 
            this.grbCPF.Controls.Add(this.txbEmailcpf);
            this.grbCPF.Controls.Add(this.txbTelefone2cpf);
            this.grbCPF.Controls.Add(this.txbTelefone1cpf);
            this.grbCPF.Controls.Add(this.txbCPF);
            this.grbCPF.Controls.Add(this.txbNome);
            this.grbCPF.Controls.Add(this.lblEmailcpf);
            this.grbCPF.Controls.Add(this.lblTelefone2cpf);
            this.grbCPF.Controls.Add(this.lblTelefone1cpf);
            this.grbCPF.Controls.Add(this.lblCPF);
            this.grbCPF.Controls.Add(this.lblNome);
            this.grbCPF.Enabled = false;
            this.grbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCPF.Location = new System.Drawing.Point(12, 275);
            this.grbCPF.Name = "grbCPF";
            this.grbCPF.Size = new System.Drawing.Size(756, 202);
            this.grbCPF.TabIndex = 3;
            this.grbCPF.TabStop = false;
            this.grbCPF.Text = "CPF";
            // 
            // txbEmailcpf
            // 
            this.txbEmailcpf.Location = new System.Drawing.Point(190, 156);
            this.txbEmailcpf.Name = "txbEmailcpf";
            this.txbEmailcpf.Size = new System.Drawing.Size(235, 20);
            this.txbEmailcpf.TabIndex = 9;
            this.txbEmailcpf.TextChanged += new System.EventHandler(this.txbEmailcpf_TextChanged);
            // 
            // txbTelefone2cpf
            // 
            this.txbTelefone2cpf.Location = new System.Drawing.Point(438, 107);
            this.txbTelefone2cpf.Name = "txbTelefone2cpf";
            this.txbTelefone2cpf.Size = new System.Drawing.Size(182, 20);
            this.txbTelefone2cpf.TabIndex = 8;
            this.txbTelefone2cpf.TextChanged += new System.EventHandler(this.txbTelefone2cpf_TextChanged);
            // 
            // txbTelefone1cpf
            // 
            this.txbTelefone1cpf.Location = new System.Drawing.Point(438, 68);
            this.txbTelefone1cpf.Name = "txbTelefone1cpf";
            this.txbTelefone1cpf.Size = new System.Drawing.Size(182, 20);
            this.txbTelefone1cpf.TabIndex = 7;
            this.txbTelefone1cpf.TextChanged += new System.EventHandler(this.txbTelefone1cpf_TextChanged);
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(190, 68);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(160, 20);
            this.txbCPF.TabIndex = 6;
            this.txbCPF.TextChanged += new System.EventHandler(this.txbCPF_TextChanged);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(190, 26);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(430, 20);
            this.txbNome.TabIndex = 5;
            this.txbNome.TextChanged += new System.EventHandler(this.txbNome_TextChanged);
            // 
            // lblEmailcpf
            // 
            this.lblEmailcpf.AutoSize = true;
            this.lblEmailcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailcpf.Location = new System.Drawing.Point(137, 159);
            this.lblEmailcpf.Name = "lblEmailcpf";
            this.lblEmailcpf.Size = new System.Drawing.Size(35, 13);
            this.lblEmailcpf.TabIndex = 4;
            this.lblEmailcpf.Text = "E-mail";
            // 
            // lblTelefone2cpf
            // 
            this.lblTelefone2cpf.AutoSize = true;
            this.lblTelefone2cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone2cpf.Location = new System.Drawing.Point(383, 110);
            this.lblTelefone2cpf.Name = "lblTelefone2cpf";
            this.lblTelefone2cpf.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone2cpf.TabIndex = 3;
            this.lblTelefone2cpf.Text = "Telefone";
            // 
            // lblTelefone1cpf
            // 
            this.lblTelefone1cpf.AutoSize = true;
            this.lblTelefone1cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone1cpf.Location = new System.Drawing.Point(383, 71);
            this.lblTelefone1cpf.Name = "lblTelefone1cpf";
            this.lblTelefone1cpf.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone1cpf.TabIndex = 2;
            this.lblTelefone1cpf.Text = "Telefone";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(137, 71);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(137, 29);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(621, 493);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(143, 36);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(303, 493);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(143, 36);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(12, 493);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(143, 36);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // grbTipo
            // 
            this.grbTipo.Controls.Add(this.rdbCNPJ);
            this.grbTipo.Controls.Add(this.rdbCPF);
            this.grbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTipo.Location = new System.Drawing.Point(12, 12);
            this.grbTipo.Name = "grbTipo";
            this.grbTipo.Size = new System.Drawing.Size(167, 44);
            this.grbTipo.TabIndex = 7;
            this.grbTipo.TabStop = false;
            this.grbTipo.Text = "Selecione";
            // 
            // lblCadastroDoador
            // 
            this.lblCadastroDoador.AutoSize = true;
            this.lblCadastroDoador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroDoador.Location = new System.Drawing.Point(354, 12);
            this.lblCadastroDoador.Name = "lblCadastroDoador";
            this.lblCadastroDoador.Size = new System.Drawing.Size(410, 31);
            this.lblCadastroDoador.TabIndex = 8;
            this.lblCadastroDoador.Text = "Cadastro de Doador / Parceiro";
            // 
            // CadastroDador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 531);
            this.ControlBox = false;
            this.Controls.Add(this.lblCadastroDoador);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grbTipo);
            this.Controls.Add(this.grbCPF);
            this.Controls.Add(this.grbCNPJ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroDador";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Dador / Parceiro";
            this.grbCNPJ.ResumeLayout(false);
            this.grbCNPJ.PerformLayout();
            this.grbCPF.ResumeLayout(false);
            this.grbCPF.PerformLayout();
            this.grbTipo.ResumeLayout(false);
            this.grbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbCNPJ;
        private System.Windows.Forms.RadioButton rdbCPF;
        private System.Windows.Forms.GroupBox grbCNPJ;
        private System.Windows.Forms.GroupBox grbCPF;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox grbTipo;
        private System.Windows.Forms.Label lblCadastroDoador;
        private System.Windows.Forms.TextBox txbEmailcnpj;
        private System.Windows.Forms.TextBox txbTelefone2cnpj;
        private System.Windows.Forms.TextBox txbTelefone1cnpj;
        private System.Windows.Forms.TextBox txbContato;
        private System.Windows.Forms.TextBox txbRazao;
        private System.Windows.Forms.TextBox txbCNPJ;
        private System.Windows.Forms.Label lblEmailcnpj;
        private System.Windows.Forms.Label lblTelefone2cnpj;
        private System.Windows.Forms.Label lblTelefone1cnpj;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.Label lblRazao;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.TextBox txbEmailcpf;
        private System.Windows.Forms.TextBox txbTelefone2cpf;
        private System.Windows.Forms.TextBox txbTelefone1cpf;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblEmailcpf;
        private System.Windows.Forms.Label lblTelefone2cpf;
        private System.Windows.Forms.Label lblTelefone1cpf;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
    }
}