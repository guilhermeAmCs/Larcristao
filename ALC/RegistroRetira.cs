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
    public partial class RegistroRetira : Form
    {
        public RegistroRetira()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTipoProduto.Enabled = true;
            cmbTipo.Enabled = true;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDescricaoProduto.Enabled = true;
            cmbDescricao.Enabled = true;
        }

        private void cmbDescricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblQuantidade.Enabled = true;
            numericUpDown1.Enabled = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
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
            btnSalvar.Enabled = false;

            numericUpDown1.Value = 0;
            numericUpDown1.Enabled = false;
            lblQuantidade.Enabled = false;

            lblDescricaoProduto.Enabled = false;
            cmbDescricao.Enabled = false;
            lblTipoProduto.Enabled = false;
            cmbTipo.Enabled = false;

            comboBox1.Text = "Clique aqui para selecionar a casa que fez a requisição ...";
        }
    }
}
