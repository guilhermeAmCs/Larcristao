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
    public partial class CadastroDador : Form
    {
        public CadastroDador()
        {
            InitializeComponent();
        }

        private void VerificaCamposCNPJ()
        {
            if (txbCNPJ.Text != "" && txbRazao.Text != "" && txbContato.Text != "" && txbTelefone1cnpj.Text != "" && txbEmailcnpj.Text != "")
            {
                btnSalvar.Enabled = true;
            }
            else
            {
                btnSalvar.Enabled = false;
            }
        }

        private void VerificaCamposCPF()
        {
            if (txbNome.Text != "" && txbCPF.Text != "" && txbTelefone1cpf.Text != "" && txbEmailcpf.Text != "")
            {
                btnSalvar.Enabled = true;
            }
            else
            {
                btnSalvar.Enabled = false;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbCNPJ.Text = ("");
            txbRazao.Text = ("");
            txbContato.Text = ("");
            txbTelefone1cnpj.Text = ("");
            txbTelefone2cnpj.Text = ("");
            txbEmailcnpj.Text = ("");

            txbNome.Text = ("");
            txbCPF.Text = ("");
            txbTelefone1cpf.Text = ("");
            txbTelefone2cpf.Text = ("");
            txbEmailcpf.Text = ("");
        }

        private void rdbCNPJ_Click(object sender, EventArgs e)
        {
            grbCPF.Enabled = false;
            grbCNPJ.Enabled = true;

            lblTelefone2cnpj.Enabled = false;
            txbTelefone2cnpj.Enabled = false;

            txbNome.Text = ("");
            txbCPF.Text = ("");
            txbTelefone1cpf.Text = ("");
            txbTelefone2cpf.Text = ("");
            txbEmailcpf.Text = ("");
        }

        private void rdbCPF_Click(object sender, EventArgs e)
        {
            grbCNPJ.Enabled = false;
            grbCPF.Enabled = true;

            lblTelefone2cpf.Enabled = false;
            txbTelefone2cpf.Enabled = false;

            txbCNPJ.Text = ("");
            txbRazao.Text = ("");
            txbContato.Text = ("");
            txbTelefone1cnpj.Text = ("");
            txbTelefone2cnpj.Text = ("");
            txbEmailcnpj.Text = ("");
        }

        private void txbCNPJ_TextChanged(object sender, EventArgs e)
        {
            VerificaCamposCNPJ();
        }

        private void txbRazao_TextChanged(object sender, EventArgs e)
        {
            VerificaCamposCNPJ();
        }

        private void txbContato_TextChanged(object sender, EventArgs e)
        {
            VerificaCamposCNPJ();
        }

        private void txbTelefone1cnpj_TextChanged(object sender, EventArgs e)
        {
            lblTelefone2cnpj.Enabled = true;
            txbTelefone2cnpj.Enabled = true;

            if (txbTelefone1cnpj.Text == "")
            {
                txbTelefone2cnpj.Text = "";
                lblTelefone2cnpj.Enabled = false;
                txbTelefone2cnpj.Enabled = false;
            }

            VerificaCamposCNPJ();
        }

        private void txbTelefone2cnpj_TextChanged(object sender, EventArgs e)
        {
            VerificaCamposCNPJ();
        }

        private void txbEmailcnpj_TextChanged(object sender, EventArgs e)
        {
            VerificaCamposCNPJ();
        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {
            VerificaCamposCPF();
        }

        private void txbCPF_TextChanged(object sender, EventArgs e)
        {
            VerificaCamposCPF();
        }

        private void txbTelefone1cpf_TextChanged(object sender, EventArgs e)
        {
            lblTelefone2cpf.Enabled = true;
            txbTelefone2cpf.Enabled = true;

            if (txbTelefone1cpf.Text == "")
            {
                txbTelefone2cpf.Text = "";
                lblTelefone2cpf.Enabled = false;
                txbTelefone2cpf.Enabled = false;
            }

            VerificaCamposCPF();
        }

        private void txbTelefone2cpf_TextChanged(object sender, EventArgs e)
        {
            VerificaCamposCPF();
        }

        private void txbEmailcpf_TextChanged(object sender, EventArgs e)
        {
            VerificaCamposCPF();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (rdbCPF.Checked == true)
            {
                if (txbCPF.Text != null && txbCPF.Text != string.Empty)
                {
                    String parametros = "" + txbCPF.Text + ", " + txbNome.Text + ", " + txbEmailcpf.Text + ", " + txbTelefone1cpf.Text + ", " + txbTelefone2cpf.Text;
                }
                else
                    MessageBox.Show("O campo CPF é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else 
            {
                if (rdbCPF.Checked == true)
                {
                    if (txbCNPJ.Text != null && txbCNPJ.Text != string.Empty)
                    {
                        String parametros = "" + txbCNPJ.Text + ", " + txbRazao.Text + ", " + txbEmailcnpj.Text + ", " + txbTelefone1cnpj.Text + ", " + txbTelefone2cnpj.Text;
                    }
                    else
                        MessageBox.Show("O campo CNPJ é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }
    }
}
