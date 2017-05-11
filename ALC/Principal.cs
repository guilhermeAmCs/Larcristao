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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrarDoador_Click(object sender, EventArgs e)
        {
            CadastroDador Cadastro = new CadastroDador();
            Cadastro.Show();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            CadastroProduto Produto = new CadastroProduto();
            Produto.Show();
        }

        private void btnRegistrarDoacao_Click(object sender, EventArgs e)
        {
            RegistroDoacao Doacao = new RegistroDoacao();
            Doacao.Show();
        }

        private void btnRegistrarRetira_Click(object sender, EventArgs e)
        {
            RegistroRetira Retira = new RegistroRetira();
            Retira.Show();
        }

        private void btnRelatorioCadastros_Click(object sender, EventArgs e)
        {
            RelatorioCadastro RelatorioCadastro = new RelatorioCadastro();
            RelatorioCadastro.Show();
        }

        private void btnRelatorioDoacaoRetirada_Click(object sender, EventArgs e)
        {
            RelatorioRegistro RelatorioRegistro = new RelatorioRegistro();
            RelatorioRegistro.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}