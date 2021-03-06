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
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "Novo ( cadastrar tipo ainda não existente )")
            {
                grbIncluirTipo.Enabled = true;

                lblDescricao.Enabled = false;
                txbDescricao.Enabled = false;

                txbDescricao.Text = "";
                btnCadastrar.Enabled = false;
            }
            else
            {
                grbIncluirTipo.Enabled = false;

                lblDescricao.Enabled = true;
                txbDescricao.Enabled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNovoTipo.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string parametros = "";
            parametros = txbNovoTipo.Text.Trim();
            //Adicionar os itens na combobox deve ficar no mesmo bloco para garantir que so sera adicionado se ele 
            //tiver sido adicionado no banco
            try
            {
                //conectar com o banco
                cmbTipo.Items.Add(txbNovoTipo.Text);
            }
            catch (Exception) {
            }
            //
            cmbTipo.Text = txbNovoTipo.Text;

            txbNovoTipo.Text = "";
            grbIncluirTipo.Enabled = false;
        }

        private void txbDescricao_TextChanged(object sender, EventArgs e)
        {
            btnCadastrar.Enabled = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Conexao x = new Conexao();
            x.query("INSERT INTO `bd_larc`.`item`(`cod_it`,`tipo`,`descricao`)VALUES(0, '" + cmbTipo.Text + "', '" + txbDescricao.Text + "');");
            DataTable minhaDatatable = x.query("Select `item`.`cod_it` from `bd_larc`.`item` where `item`.`tipo`='" + cmbTipo.Text + "' AND `item`.`descricao`='" + txbDescricao.Text + "';");
            System.Threading.Thread.Sleep(150);
            x.query("INSERT INTO `bd_larc`.`estoque`(`cod_it`,`quantidade_it`)VALUES("+ minhaDatatable.Rows[0][0] +",0);");

        }
    }
}
