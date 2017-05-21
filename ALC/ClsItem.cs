using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALC;
using ALC.Tabelas;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace ALC
{
    class ClsItem
    {
        //Instancia objeto da classe Item dentro de Tabelas
        public Item meuItem = new Item();
        public UInt16 cod_it { get; set; }
        public string und { get; set; }
        public string tipo { get; set; }
        public string descricao { get; set; }
        public float valor { get; set; }
        public string categoria { get; set; }
        public byte faixa_etaria { get; set; }


        public Conexao inserirItem()
        {
            Conexao x = new Conexao();

            string sqlCmd = string.Empty;


            sqlCmd += "INSERT INTO ITEM ("
                  // + "UND,"
                   + " TIPO,"
                   + " DESCRICAO)"
                  // + " VALOR,"
                  // + " CATEGORIA,"
                  // + " FAIXA_ETARIA)"
                   + " VALUES( "
                  // + "'" + this.und.Trim() + "', "
                   + "'" + this.tipo.Trim() + "', "
                   + "'" + this.descricao.Trim() + "'"
                   //+ "'" + this.valor+ "', "
                   //+ "'" + this.categoria.Trim() + "', "
                   //+ "'" + this.faixa_etaria + "'"
                   + ");";

            try
            {
                x.query(sqlCmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {

            }

            return x;
        }

        public ArrayList ExibeTipos()
        {
            ArrayList meuArray = new ArrayList();

            Conexao x = new Conexao();

            string strCmd = string.Empty;


            strCmd += "SELECT DISTINCT TIPO FROM ITEM ORDER BY TIPO DESC";

            DataTable minhaTable = x.query(strCmd);
            int contador = minhaTable.Rows.Count;

            if (contador == 0)
                MessageBox.Show("Nenhum registro encontrado!");

            while (contador > 0)
                {
                    meuArray.Add(minhaTable.Rows[contador-1]["TIPO"]);

                contador--;

                }



            return meuArray;
        }

        public ArrayList ExibeDescricao(string tip)
        {
            ArrayList meuArray = new ArrayList();

            Conexao x = new Conexao();

            string strCmd = string.Empty;


            strCmd += "SELECT DISTINCT DESCRICAO, TIPO FROM ITEM WHERE TIPO = '"+tip+"' ORDER BY TIPO DESC";

            DataTable minhaTable = x.query(strCmd);
            int contador = minhaTable.Rows.Count;

            if (contador == 0)
                MessageBox.Show("Nenhum registro encontrado!");

            while (contador > 0)
            {
                meuArray.Add(minhaTable.Rows[contador - 1]["DESCRICAO"]);

                contador--;

            }



            return meuArray;
        }

        public int buscaCodigoItem(string tipo, string descricao)
        {
            int cod = 0;

            Conexao x = new Conexao();

            string strCmd = string.Empty;


            strCmd += "SELECT  I.COD_IT, I.TIPO, I.DESCRICAO FROM ITEM I WHERE I.TIPO = '" + tipo+"' AND DESCRICAO = '"+descricao+"'";

            DataTable minhaTable = x.query(strCmd);
            int contador = minhaTable.Rows.Count;

            if (contador == 0)
                MessageBox.Show("Nenhum registro encontrado!");
            int i = 0;
            if (contador > 0)
            {
                cod = int.Parse((minhaTable.Rows[i]["COD_IT"].ToString()));

                contador--;
            }



            return cod;
        }

        public int quantidadeItemDisponivel(string tipo, string descricao)
        {
            int qtdDisponivel = 0;

            Conexao x = new Conexao();

            string strCmd = string.Empty;


            strCmd += "SELECT COD_IT, QUANTIDADE_IT FROM ESTOQUE WHERE COD_IT = '"+buscaCodigoItem(tipo, descricao)+"'";

            DataTable minhaTable = x.query(strCmd);
            int contador = minhaTable.Rows.Count;

            if (contador == 0)
                MessageBox.Show("Nenhum registro encontrado!");

            if (contador > 0)
            {
               qtdDisponivel = int.Parse(minhaTable.Rows[0]["QUANTIDADE_IT"].ToString());

            }



            return qtdDisponivel;
        }

         public bool atualizarEstoque(int qtd, int cod)
                {
            Conexao x = new Conexao();
            bool teste = true;

            string sqlCmd = string.Empty;


            sqlCmd += "UPDATE ESTOQUE SET quantidade_it = quantidade_it - '" + qtd + "' WHERE COD_IT ='" + cod + "'";

            try
            {
                x.query(sqlCmd);
            }
            catch (Exception ex)
            {
                teste = false;
                MessageBox.Show("Error: " + ex);
            }
            finally
            {

            }

            return teste;
        }
        /*

                public clsRetorno removerFatura()
                {
                    MySqlConnection ocnn = null;
                    clsRetorno oRet = new clsRetorno();

                    string sqlCmd = string.Empty;

                    int cod = BuscarCodigoFatura(this.numero, this.fornecedor.Trim(), this.vencimento, this.valor.Trim());


                    sqlCmd = "DELETE FROM FATURA WHERE CODIGO = '" + cod + "';";

                    try
                    {
                        ocnn = clsData.RetornaConexao();

                        MySqlCommand ocmd = new MySqlCommand(sqlCmd, ocnn);
                        int qtdeQueryAfecteds = ocmd.ExecuteNonQuery();


                        if (qtdeQueryAfecteds > 0)
                        {
                            oRet.Sucesso = true;
                            oRet.Mensagem = "Resgitro atualizado!";

                        }
                        else
                        {
                            oRet.Sucesso = false;
                            oRet.Mensagem = "Nenhum registro alterado!";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("erro :" + ex);
                    }
                    finally
                    {
                        if (ocnn.State == ConnectionState.Open)
                            ocnn.Close();
                    }

                    return oRet;
                }*/
    }
}
