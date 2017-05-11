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

        // vetores que contem a descrição eo tipo de item
        List<string> descriçãoItem = new List<string>();
        List<string> tipoItem = new List<string>();
        List<string> quantidadeDoItem = new List<string>();
        //lista de parceiros e naoparceiros        
        string doador;
        int codDoador;

        public RegistroDoacao()
        {
            InitializeComponent();
            //pO combobox tipo pode ser preenchido logo quando a tela e iniciada
            //diferente dos outros que dependem do rdiobutton ou da selecao feita
            // no cmbtipo
            Conexao x = new Conexao();
            DataTable minhaDataTable = x.query("SELECT DISTINCT item.`tipo` from item;");
            cmbTipo.DataSource = minhaDataTable;
            cmbTipo.DisplayMember = "tipo";
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
            Conexao x = new Conexao();
            DataTable minhaDataTable = x.query("SELECT parceiro.`cnpj` from parceiro;");
            List<DataRow> colunasDaTabela = minhaDataTable.AsEnumerable().ToList();
            cmbEmpresa.DataSource = minhaDataTable;
            cmbEmpresa.DisplayMember = "cnpj";
        }

        private void rdbCPF_Click(object sender, EventArgs e)
        {
            grbDescDoador.Enabled = true;

            lblCNPJ.Enabled = false;
            cmbEmpresa.Enabled = false;

            lblCPF.Enabled = true;
            cmbPessoa.Enabled = true;

            grbDescProduto.Enabled = false;
            Conexao x = new Conexao();
            DataTable minhaDataTable = x.query("SELECT nao_parceiro.`cpf` from nao_parceiro;");
            List<DataRow> colunasDaTabela = minhaDataTable.AsEnumerable().ToList();
            cmbPessoa.DataSource = minhaDataTable;
            cmbPessoa.DisplayMember = "cpf";
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
                doador = cmbEmpresa.Text;
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
                doador = cmbPessoa.Text;
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
                Conexao x = new Conexao();
                DataTable minhaDataTable = x.query("SELECT DISTINCT  item.`descricao` from item;");
                cmbDescricao.DataSource = minhaDataTable;
                cmbDescricao.DisplayMember = "descricao";
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
                btnAdicionar.Enabled = true;
            }
            else
            {
                btnAdicionar.Enabled = false;
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

        private void grbDescProduto_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Conexao x = new Conexao();
            DataTable minhaDataTable;
            if (rdbCNPJ.Checked == true)
                minhaDataTable = x.query("Select nao_parceiro.cod_doador from bd_larc.`nao_parceiro` where cpf ='" + doador + "'");
            else
                minhaDataTable = x.query("Select parceiro.cod_doador from bd_larc.`parceiro` where cnpj ='" + doador + "'");
            codDoador = Convert.ToInt32(minhaDataTable.Rows[0][0].ToString());
            finalizarDoacao telaDeFinalização = new finalizarDoacao(descriçãoItem, tipoItem, doador, quantidadeDoItem, codDoador);
            telaDeFinalização.Show();
        }
        //Adiciona os items no datagrid view ao lado
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (rdbCNPJ.Checked) {
                dataGridView1.Rows.Add(cmbEmpresa.Text, cmbTipo.Text,cmbDescricao.Text, numericUpDown1.Value.ToString());
                descriçãoItem.Add(cmbDescricao.Text);
                tipoItem.Add(cmbTipo.Text);
                quantidadeDoItem.Add(numericUpDown1.Value.ToString());
                        
            }
            else if (rdbCPF.Checked)
            {
                dataGridView1.Rows.Add(cmbPessoa.Text, cmbTipo.Text, cmbDescricao.Text, numericUpDown1.Value.ToString());
                descriçãoItem.Add(cmbDescricao.Text);
                tipoItem.Add(cmbTipo.Text);
                quantidadeDoItem.Add(numericUpDown1.Value.ToString());
            }
            else {
                MessageBox.Show("Você deve selecionar um tipo de doador",
                    "Doador não selerionado",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            btnAdicionar.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void RegistroDoacao_Load(object sender, EventArgs e)
        {

        }
    }
}