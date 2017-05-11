using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALC
{
    public partial class RegistroDoacao : Form
    {
        public RegistroDoacao()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbCNPJ_Click(object sender, EventArgs e)
        {
            grbDescDoador.Enabled = true;

            lblCPF.Enabled = false;
            cmbPessoa.Enabled = false;

            lblCNPJ.Enabled = true;
            cmbEmpresa.Enabled = true;

            grbDescProduto.Enabled = false;
        }

        private void rdbCPF_Click(object sender, EventArgs e)
        {
            grbDescDoador.Enabled = true;

            lblCNPJ.Enabled = false;
            cmbEmpresa.Enabled = false;

            lblCPF.Enabled = true;
            cmbPessoa.Enabled = true;

            grbDescProduto.Enabled = false;
        }

        private void rdbOutros_Click(object sender, EventArgs e)
        {
            grbDescDoador.Enabled = false;
            grbDescProduto.Enabled = true;

            lblDescricaoProduto.Enabled = false;
            cmbDescricao.Enabled = false;
            lblQuantidade.Enabled = false;
            numericUpDown1.Enabled = false;
        }

        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmpresa.Text != "Clique aqui para selecionar a empresa ...")
            {
                grbDescProduto.Enabled = true;

                lblDescricaoProduto.Enabled = false;
                cmbDescricao.Enabled = false;
                lblQuantidade.Enabled = false;
                numericUpDown1.Enabled = false;
            }
            else
            {
                grbDescProduto.Enabled = false;
            }
        }

        private void cmbPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPessoa.Text != "Clique aqui para selecionar a pessoa ...")
            {
                grbDescProduto.Enabled = true;

                lblDescricaoProduto.Enabled = false;
                cmbDescricao.Enabled = false;
                lblQuantidade.Enabled = false;
                numericUpDown1.Enabled = false;
            }
            else
            {
                grbDescProduto.Enabled = false;
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.Text != "Clique aqui para selecionar o tipo do produto ...")
            {
                lblDescricaoProduto.Enabled = true;
                cmbDescricao.Enabled = true;
            }
            else
            {
                lblDescricaoProduto.Enabled = false;
                cmbDescricao.Enabled = false;
            }
        }

        private void cmbDescricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDescricao.Text != "Clique aqui para selecionar a descrição do produto ...")
            {
                lblQuantidade.Enabled = true;
                numericUpDown1.Enabled = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                btnSalvar.Enabled = true;
            }
            else
            {
                btnSalvar.Enabled = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cmbTipo.Text = "Clique aqui para selecionar o tipo do produto ...";
            cmbDescricao.Text = "Clique aqui para selecionar a descrição do produto ...";

            numericUpDown1.Value = 0;

            cmbEmpresa.Text = "Clique aqui para selecionar a empresa...";
            cmbPessoa.Text = "Clique aqui para selecionar a pessoa ...";

            grbDescProduto.Enabled = false;
            grbDescDoador.Enabled = false;

            rdbCNPJ.Checked = false;
            rdbCPF.Checked = false;
            rdbOutros.Checked = false;

            btnSalvar.Enabled = false;
        }
    }
}