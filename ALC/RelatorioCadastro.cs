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
    public partial class RelatorioCadastro : Form
    {
        public RelatorioCadastro()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRelatorioGeral_Click(object sender, EventArgs e)
        {
            //--> Melhor gerar um  .txt  .doc  .pdf  pra depois a pessoa imprimir via Word, Adobe, etc...
        }
    }
}
