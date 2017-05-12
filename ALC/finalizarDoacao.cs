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
    public partial class finalizarDoacao : Form
    {
        List<string> descriçãoDosItems;
        List<string> tipoDosItems;
        List<double> listaDeValores;
        List<string> itemsNaoEncontrados;
        List<string> quantidadeItens;
        int doadorCod;
        String Doador;
        double valorTotal;

        public finalizarDoacao(List<string> listDesc, List<string> listTipo, string doadorDosProdutos, List<string> quantidade, int codDoador)
        {
            valorTotal = 0;
            Doador = doadorDosProdutos;
            descriçãoDosItems = new List<string>(listDesc);
            tipoDosItems = new List<string>(listTipo);
            quantidadeItens = new List<string>(quantidade);
            itemsNaoEncontrados = new List<string>();
            listaDeValores = new List<double>();
            InitializeComponent();
            label1.Text = label1.Text + "  " + Doador;
            doadorCod = codDoador;
            btnRegistrar.Enabled = false;
            CarregarDataGridView();

        }

        private void CarregarDataGridView()
        {

            for (int i = 0; i < descriçãoDosItems.Count; i++)
            {
                Conexao x = new Conexao();
                if (x.conexaoBemsucedida == true)
                {
                    DataTable minhaDataTable = x.query("SELECT valor FROM item WHERE descricao = '" + descriçãoDosItems[i] + "' AND tipo = '" + tipoDosItems[i] + "'");
                    if (minhaDataTable.Rows.Count == 0)
                    {
                        quantidadeItens[i] = "Item não cadastrado" + quantidadeItens[i];
                        listaDeValores.Add(0.0);
                    }
                    else
                    {
                        try
                        {
                            listaDeValores.Add(Convert.ToDouble(minhaDataTable.Rows[0][0].ToString()));
                        }
                        catch
                        {
                            listaDeValores.Add(0);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("O programa não conseguiu conectar com o banco de dados. Aguarde um momento e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            lblValorTotal.Text = "R$  " + valorTotal.ToString();

            for (int i = 0; i < descriçãoDosItems.Count; i++)
            {
                if (quantidadeItens[i][0] != 'I')
                {
                    dataGridView1.Rows.Add(tipoDosItems[i], descriçãoDosItems[i], quantidadeItens[i], listaDeValores[i], double.Parse(quantidadeItens[i]) * listaDeValores[i]);
                    valorTotal += double.Parse(quantidadeItens[i]) * listaDeValores[i];
                }
                else
                    dataGridView1.Rows.Add(tipoDosItems[i], descriçãoDosItems[i], quantidadeItens[i], listaDeValores[i], "Não contabilizado");
            }
            lblValorTotal.Text = "R$ " + valorTotal;
            btnRegistrar.Enabled = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Conexao x = new Conexao();
            Int32 codDoacao;

            x.query("Insert INTO bd_larc.`doacao` values (0, '" + valorTotal.ToString().Replace(',', '.') + "', '" + doadorCod + "');");
            DataTable tabeladoacao = x.query("Select cod_doacao FROM bd_larc.`doacao` where cod_doador='" + doadorCod + "' AND valor_total='" + valorTotal + "';");
            codDoacao = Convert.ToInt32(tabeladoacao.Rows[0][0].ToString());
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value.ToString() != "Não contabilizado")
                {
                    DataTable minhaDataTable = x.query("Select cod_it from bd_larc.`item` where `tipo`='" + dataGridView1.Rows[i].Cells[0].Value + "' AND `descricao`='" + dataGridView1.Rows[i].Cells[1].Value + "';");
                    x.query("Insert INTO bd_larc.`doacxitem` values (" + Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString()) + ", " + int.Parse(minhaDataTable.Rows[0][0].ToString()) + ", " + codDoacao + ");");
                }
            }
            MessageBox.Show("Operação concluida", "Doação registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
