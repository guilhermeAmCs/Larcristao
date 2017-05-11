using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace ALC
{
    /// <summary>
    /// Classe para conexão de dados simplificada com o MySQL
    /// </summary>
    public class Conexao : IDisposable
    {
        /// <summary>
        /// Construtor sobrecarregado. Recebe os parâmetros necessários para configurar a conexão com o banco.
        /// </summary>
        /// <param name="Server">Endereço ou nome do servidor. ex.: 127.0.0.1 ou LocalHost</param>
        /// <param name="Port">Porta de conexão do servidor sql. Padrão 3306. </param>
        /// <param name="Database">Nome do Banco(schema).</param>
        /// <param name="UserID">Nome de usuário do servidor. Padrã: root.</param>
        /// <param name="Password">Senha. Padrão: root, ou sem senha.</param>
        public bool conexaoBemsucedida;

        public Conexao(string Server, string Port, string Database, string UserID, string Password)
        {
            conectar = new MySqlConnection("Server =" + Server + "; Port =" + Port + "; Database =" + Database + "; Uid =" + UserID + "; Pwd =" + Password);
            conexaoBemsucedida = true;
        }
        /// <summary>
        /// Construtuor padrão. Cria uma instância de conexao com os parâmetros padrões. 
        /// </summary>
        public Conexao()
        {
            conectar = new MySqlConnection("Server =127.0.0.1; Port = 3306; Database = bd_larc; Uid = root; Pwd = 1234");
            conexaoBemsucedida = true;
        }

        bool disposed = false;
        private MySqlConnection conectar;
        private MySqlDataAdapter adaptador;

        private MySqlCommand comando;

        /// <summary>
        /// Efetua uma tentativa de abrir conexão com o bd.
        /// </summary>
        public void AbrirConexao()
        {
            try
            {
                conectar.Open();

                comando.ExecuteNonQuery();

                conectar.Close();
            }
            catch (Exception e)
            {
                conexaoBemsucedida = false;
                MessageBox.Show(e.Message.ToString(), "Não foi possível Efetuar a Conexão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #region Operações de Inserção e Atualização


        /// <summary>
        /// Efetua a inserção de uma tupla na tabela Item do bd_larc
        /// </summary>
        /// <param name="item">Uma instância preênchida da classe item.</param>
        public void inserir(Tabelas.Item item )
        {
            comando = conectar.CreateCommand();

            if (item.cod_it == 0)
                comando.CommandText = "INSERT INTO Item(und,tipo,descricao,valor,categoria,faixa_etaria) Values(?und,?tipo,?descricao,?valor,?categoria,?faixa_etaria)";
            else
            {
                comando.CommandText = "UPDATE Item SET und = ?und, tipo = ?tipo,descricao = ?descricao,valor = ?valor,categoria = ?categoria, faixa_etaria = ?faixa_etaria WHERE cod_it = ?cod_it";
                comando.Parameters.AddWithValue("?cod_it", item.cod_it);
            }

            comando.Parameters.AddWithValue("?und",item.und);
            comando.Parameters.AddWithValue("?tipo", item.tipo);
            comando.Parameters.AddWithValue("?descricao", item.descricao);
            comando.Parameters.AddWithValue("?valor", item.valor);
            comando.Parameters.AddWithValue("?categoria", item.categoria);
            comando.Parameters.AddWithValue("?faixa_etaria", item.faixa_etaria);

            AbrirConexao();

        }

        /// <summary>
        /// Efetua a inserção de uma tupla na tabela Casa do bd_larc.
        /// </summary>
        /// <param name="casa">Uma instância preênchida da classe casa.</param>
        public void inserir(Tabelas.Casa casa)
        {
            comando = conectar.CreateCommand();

            if (casa.cod_casa == 0)
                comando.CommandText = "INSERT INTO Casa(nome) Values(?nome)";
            else
            {
                comando.CommandText = "UPDATE Casa SET nome = ?nome WHERE cod_casa = ?cod_casa";
                comando.Parameters.AddWithValue("?cod.it", casa.cod_casa);
            }
            

            comando.CommandText = "INSERT INTO Casa(nome) Values(?nome)";
            comando.Parameters.AddWithValue("?nome",casa.nome);

            AbrirConexao();

        }

        /// <summary>
        /// Efetua a inserção de uma tupla na tabela Requisita do bd_larc.
        /// </summary>
        /// <param name="requisita">Uma instância preênchida da classe casa.</param>
        public void inserir(Tabelas.Requisita requisita)
        {
            comando = conectar.CreateCommand();

            if (requisita.cod_req == 0)
                comando.CommandText = "INSERT INTO Requisita(data, qtd, cod_casa, cod_it) Values(?data, ?qtd, ?cod_casa, ?cod_it)";
            else
            {
                comando.CommandText = "Update Requisita SET data = ?data, qtd = ?qtd, cod_casa = ?cod_casa, cod_it = ?cod_it WHERE cod_req = ?cod_req";
                comando.Parameters.AddWithValue("?cod_req", requisita.cod_req);
            }

            comando.Parameters.AddWithValue("?data", requisita.data);
            comando.Parameters.AddWithValue("?qtd", requisita.qtd);
            comando.Parameters.AddWithValue("?cod_casa", requisita.cod_casa);
            comando.Parameters.AddWithValue("?cod_it", requisita.cod_it);

            AbrirConexao();

        }

        /// <summary>
        /// Efetua a inserção de uma tupla na tabela Doador do bd_larc.
        /// </summary>
        /// <param name="doador">Uma instância preênchida da classe Doador.</param>
        public void inserir(Tabelas.Doador doador)
        {
            comando = conectar.CreateCommand();

            if (doador.cod_doador == 0)
                comando.CommandText = "INSERT INTO Doados(email, telefone, telefone2) Values(?email, ?telefone, ?telefone2)";
            else
            {
                comando.CommandText = "UPDATE Doados SET email = ?email, telefone = ?telefone, telefone2 = ?telefone2 WHERE cod_doador = ?cod_doador";
                comando.Parameters.AddWithValue("?cod_doador", doador.cod_doador);
            }

            comando.Parameters.AddWithValue("?email", doador.email);
            comando.Parameters.AddWithValue("?telefone", doador.telefone);
            comando.Parameters.AddWithValue("?telefone2", doador.telefone2);

            AbrirConexao();

        }

        /// <summary>
        /// Efetua a inserção de uma tupla na tabela Doacao do bd_larc.
        /// </summary>
        /// <param name="doacao">Uma instância preênchida da classe Doacao.</param>
        public void inserir(Tabelas.Doacao doacao)
        {
            comando = conectar.CreateCommand();

            if (doacao.cod_doacao ==0)
                comando.CommandText = "INSERT INTO Doacao(data, valor_total, cod_doador) Values(?data, ?valor_total, ?cod_doador)";
            else
            {
                comando.CommandText = "UPDATE Doacao set data = ?data, valor_total = ?valor_total, cod_doador = ?cod_doador WHERE cod_doacao = ?cod_doacao";
                comando.Parameters.AddWithValue("?cod_doacao", doacao.cod_doacao);
            }

            comando.Parameters.AddWithValue("?data", doacao.data);
            comando.Parameters.AddWithValue("?valor_total", doacao.valor_total);
            comando.Parameters.AddWithValue("?cod_doador", doacao.cod_doador);

            AbrirConexao();

        }

        /// <summary>
        ///  Efetua a inserção de uma tupla na tabela DoacxItem do bd_larc.
        /// </summary>
        /// <param name="DoacxItem">Uma instância preênchida da classe DoacxItem.</param>
        public void inserir(Tabelas.DoacxItem DoacxItem, bool updt)
        {
            comando = conectar.CreateCommand();

            if (!updt)
                comando.CommandText = "INSERT INTO DoacxItem(qtd, cod_it, cod_doacao) Values(?qtd, ?cod_it, ?cod_doacao)";
            else
                comando.CommandText = "UPDATE DoacxItem SET qtd = ?qtd WHERE cod_it = ?cod_it AND cod_doacao = ?cod_doacao";

            comando.Parameters.AddWithValue("?qtd", DoacxItem.qtd);
            comando.Parameters.AddWithValue("?cod_it", DoacxItem.cod_it);
            comando.Parameters.AddWithValue("?cod_doacao", DoacxItem.cod_doacao);

            AbrirConexao();

        }

        /// <summary>
        /// Efetua a inserção de uma tupla na tabela nao_parceiro do bd_larc.
        /// </summary>
        /// <param name="nao_parceiro">Uma instância preênchida da classe nao_parceiro.</param>
        public void inserir(Tabelas.Nao_parceiro nao_parceiro, bool updt)
        {
            comando = conectar.CreateCommand();

            if (!updt)
                comando.CommandText = "INSERT INTO Nao_parceiro(nome, cpf, cod_doador) Values(?nome, ?cpf, ?cod_doador)";
            else
                comando.CommandText = "UPDATE Nao_parceiro SET nome = ?nome, cpf = ?cpf WHERE cod_doador = ?cod_doador";

            comando.Parameters.AddWithValue("?nome", nao_parceiro.nome);
            comando.Parameters.AddWithValue("?cpf", nao_parceiro.cpf);
            comando.Parameters.AddWithValue("?cod_doador", nao_parceiro.cod_doador);

            AbrirConexao();

        }

        /// <summary>
        /// Efetua a inserção de uma tupla na tabela parceiro do bd_larc.
        /// </summary>
        /// <param name="parceiro">Uma instância preênchida da classe parceiro.</param>
        public void inserir(Tabelas.Parceiro parceiro, bool updt)
        {
            comando = conectar.CreateCommand();

            if (!updt)
                comando.CommandText = "INSERT INTO Parceiro(razao_social, cnpj, cod_doador) Values(?razao_social, ?cnpj, ?cod_doador)";
            else
                comando.CommandText = "UPDATE Parceiro SET razao_social = ?razao_social, cnpj = ?cnpj, nome_fant = ?nome_fant WHERE cod_doador = ? cod_doador";

            comando.Parameters.AddWithValue("?razao_social", parceiro.razao_social);
            comando.Parameters.AddWithValue("?cnpj", parceiro.cnpj);
            comando.Parameters.AddWithValue("?cod_doador", parceiro.cod_doador);

            AbrirConexao();

        }

        #endregion



        /// <summary>
        /// Efetua a exclusão da tupla na tabela correspondente ao parâmetro enviado.
        /// </summary>
        /// <param name="tupla">Objeto do tipo Tabelas."tabela" devidamente istanciado e com o campo identificador preenchido.</param>
        public void excluir(object tupla)
        {
            comando = conectar.CreateCommand();

            if (tupla.GetType().Equals(typeof(Tabelas.Casa)))
            {
                comando.CommandText = "DELETE FROM Casa WHERE cod_casa = ?cod_casa";
                comando.Parameters.AddWithValue("?cod_casa", ((Tabelas.Casa)tupla).cod_casa);
            }
            else if (tupla.GetType().Equals(typeof(Tabelas.Doacao)))
            {
                comando.CommandText = "DELETE FROM Doacao WHERE cod_doacao = ?cod_doacao";
                comando.Parameters.AddWithValue("?cod_doacao", ((Tabelas.Doacao)tupla).cod_doacao);
            }
            else if (tupla.GetType().Equals(typeof(Tabelas.Doador)))
            {
                comando.CommandText = "DELETE FROM Doador WHERE cod_doador = ?cod_doador";
                comando.Parameters.AddWithValue("?cod_doador", ((Tabelas.Doador)tupla).cod_doador);
            }
            else if (tupla.GetType().Equals(typeof(Tabelas.Item)))
            {
                comando.CommandText = "DELETE FROM Item WHERE cod_it = ?cod_it";
                comando.Parameters.AddWithValue("?cod_it", ((Tabelas.Item)tupla).cod_it);
            }
            else if (tupla.GetType().Equals(typeof(Tabelas.Requisita)))
            {
                comando.CommandText = "DELETE FROM Requisita WHERE cod_req = ?cod_req";
                comando.Parameters.AddWithValue("?cod_req", ((Tabelas.Requisita)tupla).cod_req);
            }
            else if (tupla.GetType().Equals(typeof(Tabelas.DoacxItem)))
            {
                comando.CommandText = "DELETE FROM DoacxItem WHERE cod_it = ?cod_it AND cod_doacao = ?cod_doacao";
                comando.Parameters.AddWithValue("?cod_it", ((Tabelas.DoacxItem)tupla).cod_it);
                comando.Parameters.AddWithValue("?cod_it", ((Tabelas.DoacxItem)tupla).cod_doacao);
            }
            else if (tupla.GetType().Equals(typeof(Tabelas.Parceiro)))
            {
                comando.CommandText = "DELETE FROM Parceiro WHERE cod_docador = ?cod_doador";
                comando.Parameters.AddWithValue("?cod_it", ((Tabelas.Parceiro)tupla).cod_doador);
            }
            else if (tupla.GetType().Equals(typeof(Tabelas.Nao_parceiro)))
            {
                comando.CommandText = "DELETE FROM Nao_parceiro WHERE cpf = ?cpd AND cod_doador = ?cod_doador";
                //insert.Parameters.AddWithValue("?cod_it", ((Tabelas.Nao_parceiro)tupla).cpf);
                comando.Parameters.AddWithValue("?cod_it", ((Tabelas.Nao_parceiro)tupla).cod_doador);
            }

            AbrirConexao();
        }

        /// <summary>
        /// Efetua o camando "SELECT *" de acordo com a tabela especificada pelo parâmetro.
        /// </summary>
        /// <param name="tabela">Nome da tabela a qual deseja requisitar.</param>
        /// <returns>Retorna toda a tabela especificada pelo parâmetro.</returns>
        public DataTable gettabela(string tabela)
        {
            DataTable x = new DataTable();
            comando = conectar.CreateCommand();
            comando.CommandText = "SELECT * FROM " + tabela;

            try
            {
                conectar.Open();

                comando = new MySqlCommand(comando.CommandText, conectar);
                adaptador = new MySqlDataAdapter(comando);

                adaptador.Fill(x);

                conectar.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Não foi possível Efetuar a Conexão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return x;

        }

        /// <summary>
        /// Efetua o comando enviado pelo parâmetro.
        /// </summary>
        /// <param name="expressão">Comando SQL SELECT customisado.</param>
        /// <returns>Retorna o resultado da consulta no banco em formato de DataTable.</returns>
        public DataTable query(string expressão)
        {

            DataTable x = new DataTable();
            comando = conectar.CreateCommand();
            comando.CommandText = expressão;

            try
            {
                conectar.Open();

                comando = new MySqlCommand(comando.CommandText, conectar);
                adaptador = new MySqlDataAdapter(comando);

                adaptador.Fill(x);

                conectar.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Não foi possível Efetuar a Conexão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conexaoBemsucedida = false;
            }

            return x;

        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                conectar.Dispose();
                //adaptador.Dispose();
                comando.Dispose();
                
                // Free any other managed objects here.
                //
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }


    }
}
