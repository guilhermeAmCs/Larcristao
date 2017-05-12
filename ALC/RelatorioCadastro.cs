﻿using System;
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
            buscarRelatorios();
        }

        private void buscarRelatorios()
        {
            Conexao x = new Conexao();
            DataTable minhaDatatable = x.query("SELECT `parceiro`.`cnpj`, `parceiro`.`razao_social`,`doador`.`telefone`, `doador`.`email`,`doador`.`telefone2` FROM bd_larc.parceiro inner join `bd_larc`.`doador` on `doador`.`cod_doador`= `parceiro`.`cod_doador`; ");
            foreach (DataRow item in minhaDatatable.Rows)
            {
                dataGridView1.Rows.Add(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString());
            }

            minhaDatatable = x.query("SELECT `item`.`tipo`, `item`.`descricao`, sum(`doacxitem`.`qtd`) FROM `bd_larc`.`doacxitem` inner join `bd_larc`.`item` on `doacxitem`.`cod_it`= `item`.`cod_it` Group by `item`.`tipo`, `item`.`descricao`; ");
            foreach (DataRow item in minhaDatatable.Rows)
            {
                dataGridView2.Rows.Add(item[0].ToString(), item[1].ToString(), item[2].ToString());
            }

            minhaDatatable = x.query("SELECT `nao_parceiro`.`cpf`, `nao_parceiro`.`nome`, `doador`.`email`, `doador`.`telefone` FROM `bd_larc`.`nao_parceiro` inner join `bd_larc`.`doador` on `doador`.`cod_doador`= `nao_parceiro`.`cod_doador`; ");
            foreach (DataRow item in minhaDatatable.Rows)
            {
                dataGridView3.Rows.Add(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString());
            }

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
