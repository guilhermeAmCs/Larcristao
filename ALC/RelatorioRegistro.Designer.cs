namespace ALC
{
    partial class RelatorioRegistro
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
            this.lblRelatorioRetiraDoacao = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.grpRelatorioDoacoes = new System.Windows.Forms.GroupBox();
            this.grbRelatorioRetira = new System.Windows.Forms.GroupBox();
            this.btnDoacaoSemanal = new System.Windows.Forms.Button();
            this.btnDoacaoMensal = new System.Windows.Forms.Button();
            this.btnDoacaoAnual = new System.Windows.Forms.Button();
            this.btnRetiraSemanal = new System.Windows.Forms.Button();
            this.btnRetiraMensal = new System.Windows.Forms.Button();
            this.btnRetiraAnual = new System.Windows.Forms.Button();
            this.grpRelatorioDoacoes.SuspendLayout();
            this.grbRelatorioRetira.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRelatorioRetiraDoacao
            // 
            this.lblRelatorioRetiraDoacao.AutoSize = true;
            this.lblRelatorioRetiraDoacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatorioRetiraDoacao.Location = new System.Drawing.Point(168, 22);
            this.lblRelatorioRetiraDoacao.Name = "lblRelatorioRetiraDoacao";
            this.lblRelatorioRetiraDoacao.Size = new System.Drawing.Size(406, 31);
            this.lblRelatorioRetiraDoacao.TabIndex = 9;
            this.lblRelatorioRetiraDoacao.Text = "Relatorio de Doação e Retiras";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(264, 371);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(143, 36);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // grpRelatorioDoacoes
            // 
            this.grpRelatorioDoacoes.Controls.Add(this.btnDoacaoAnual);
            this.grpRelatorioDoacoes.Controls.Add(this.btnDoacaoMensal);
            this.grpRelatorioDoacoes.Controls.Add(this.btnDoacaoSemanal);
            this.grpRelatorioDoacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRelatorioDoacoes.Location = new System.Drawing.Point(23, 75);
            this.grpRelatorioDoacoes.Name = "grpRelatorioDoacoes";
            this.grpRelatorioDoacoes.Size = new System.Drawing.Size(633, 124);
            this.grpRelatorioDoacoes.TabIndex = 11;
            this.grpRelatorioDoacoes.TabStop = false;
            this.grpRelatorioDoacoes.Text = "Relatorios de Doações";
            // 
            // grbRelatorioRetira
            // 
            this.grbRelatorioRetira.Controls.Add(this.btnRetiraAnual);
            this.grbRelatorioRetira.Controls.Add(this.btnRetiraMensal);
            this.grbRelatorioRetira.Controls.Add(this.btnRetiraSemanal);
            this.grbRelatorioRetira.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRelatorioRetira.Location = new System.Drawing.Point(23, 221);
            this.grbRelatorioRetira.Name = "grbRelatorioRetira";
            this.grbRelatorioRetira.Size = new System.Drawing.Size(633, 124);
            this.grbRelatorioRetira.TabIndex = 12;
            this.grbRelatorioRetira.TabStop = false;
            this.grbRelatorioRetira.Text = "Relatorios de Retiras";
            // 
            // btnDoacaoSemanal
            // 
            this.btnDoacaoSemanal.Location = new System.Drawing.Point(39, 34);
            this.btnDoacaoSemanal.Name = "btnDoacaoSemanal";
            this.btnDoacaoSemanal.Size = new System.Drawing.Size(167, 65);
            this.btnDoacaoSemanal.TabIndex = 0;
            this.btnDoacaoSemanal.Text = "Relatório Semanal\r\n\r\nde Doações";
            this.btnDoacaoSemanal.UseVisualStyleBackColor = true;
            // 
            // btnDoacaoMensal
            // 
            this.btnDoacaoMensal.Location = new System.Drawing.Point(233, 34);
            this.btnDoacaoMensal.Name = "btnDoacaoMensal";
            this.btnDoacaoMensal.Size = new System.Drawing.Size(167, 65);
            this.btnDoacaoMensal.TabIndex = 1;
            this.btnDoacaoMensal.Text = "Relatório Mensal\r\n\r\nde Doações";
            this.btnDoacaoMensal.UseVisualStyleBackColor = true;
            // 
            // btnDoacaoAnual
            // 
            this.btnDoacaoAnual.Location = new System.Drawing.Point(427, 34);
            this.btnDoacaoAnual.Name = "btnDoacaoAnual";
            this.btnDoacaoAnual.Size = new System.Drawing.Size(167, 65);
            this.btnDoacaoAnual.TabIndex = 2;
            this.btnDoacaoAnual.Text = "Relatório Anual\r\n\r\nde Doações";
            this.btnDoacaoAnual.UseVisualStyleBackColor = true;
            // 
            // btnRetiraSemanal
            // 
            this.btnRetiraSemanal.Location = new System.Drawing.Point(38, 33);
            this.btnRetiraSemanal.Name = "btnRetiraSemanal";
            this.btnRetiraSemanal.Size = new System.Drawing.Size(167, 65);
            this.btnRetiraSemanal.TabIndex = 0;
            this.btnRetiraSemanal.Text = "Relatório Semanal\r\n\r\nde Retiras";
            this.btnRetiraSemanal.UseVisualStyleBackColor = true;
            // 
            // btnRetiraMensal
            // 
            this.btnRetiraMensal.Location = new System.Drawing.Point(232, 35);
            this.btnRetiraMensal.Name = "btnRetiraMensal";
            this.btnRetiraMensal.Size = new System.Drawing.Size(167, 65);
            this.btnRetiraMensal.TabIndex = 1;
            this.btnRetiraMensal.Text = "Relatório Semanal\r\n\r\nde Retiras";
            this.btnRetiraMensal.UseVisualStyleBackColor = true;
            // 
            // btnRetiraAnual
            // 
            this.btnRetiraAnual.Location = new System.Drawing.Point(426, 33);
            this.btnRetiraAnual.Name = "btnRetiraAnual";
            this.btnRetiraAnual.Size = new System.Drawing.Size(167, 65);
            this.btnRetiraAnual.TabIndex = 2;
            this.btnRetiraAnual.Text = "Relatório Semanal\r\n\r\nde Retiras";
            this.btnRetiraAnual.UseVisualStyleBackColor = true;
            // 
            // RelatorioRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 421);
            this.ControlBox = false;
            this.Controls.Add(this.grbRelatorioRetira);
            this.Controls.Add(this.grpRelatorioDoacoes);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblRelatorioRetiraDoacao);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RelatorioRegistro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de Doações e Retiras";
            this.grpRelatorioDoacoes.ResumeLayout(false);
            this.grbRelatorioRetira.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRelatorioRetiraDoacao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox grpRelatorioDoacoes;
        private System.Windows.Forms.GroupBox grbRelatorioRetira;
        private System.Windows.Forms.Button btnDoacaoAnual;
        private System.Windows.Forms.Button btnDoacaoMensal;
        private System.Windows.Forms.Button btnDoacaoSemanal;
        private System.Windows.Forms.Button btnRetiraAnual;
        private System.Windows.Forms.Button btnRetiraMensal;
        private System.Windows.Forms.Button btnRetiraSemanal;
    }
}