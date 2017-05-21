using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
namespace ALC
{
    public partial class RegistroRetira : Form
    {
        ClsItem meuItem = new ClsItem();
        Conexao x = new Conexao();
        public RegistroRetira()
        {
            InitializeComponent();

            

            string strCmd = string.Empty;


            strCmd += "SELECT DISTINCT NOME FROM CASA ORDER BY NOME DESC";

            DataTable minhaTable = x.query(strCmd);
            int contador = minhaTable.Rows.Count;

            if (contador == 0)
                comboBox1.Items.Add("Nenhum registro encontrado!");

            while (contador > 0)
            {
                comboBox1.Items.Add(minhaTable.Rows[contador - 1]["NOME"]);

                contador--;

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable minhaTable = x.query("SELECT DISTINCT item.`tipo` from item;");
            cmbTipo.DataSource = minhaTable;
            cmbTipo.DisplayMember = "tipo";
            cmbTipo.Enabled = true;
            lblTipoProduto.Enabled = true;
            cmbTipo.Enabled = true;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable minhaTable = x.query("SELECT DISTINCT  item.`descricao` from item WHERE item.`tipo` = '" + cmbTipo.Text + "';");
            cmbDescricao.DataSource = minhaTable;
            cmbDescricao.DisplayMember = "descricao";
            cmbDescricao.Enabled = true;
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



        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            DataTable minhaDataTable = x.query("Select cod_it from bd_larc.`item` where `tipo`='" + cmbTipo.Text + "' AND `descricao`='" + cmbDescricao.Text + "';");
            int qtdDisponivel = int.Parse(minhaDataTable.Rows[0][0].ToString());
            if (qtdDisponivel < int.Parse(numericUpDown1.Value.ToString()))
                MessageBox.Show("A quantidade solicitada não está disponivel.\nExistem " + qtdDisponivel + " unidades em estoque.\nFavor alterar a quantidade solicitada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (qtdDisponivel == 0)
                MessageBox.Show("Não há nenhum unidade disponivel em estoque.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (meuItem.atualizarEstoque(qtdDisponivel - int.Parse(numericUpDown1.Value.ToString()), meuItem.buscaCodigoItem(cmbTipo.Text, cmbDescricao.Text)))
                {
                    try
                    {
                        x.query(" UPDATE `bd_larc`.`estoque` SET `estoque`.`quantidade_it` = `estoque`.`quantidade_it` - " + numericUpDown1.Value + " WHERE `estoque`.`cod_it`= '" + int.Parse(minhaDataTable.Rows[0][0].ToString()) + "';");
                        MessageBox.Show("Retirada de material feita com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Retirada de material não foi efetuada.\nTente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Retirada de material não foi efetuada.\nTente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
