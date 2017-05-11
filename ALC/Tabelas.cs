using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarCristao
{
    /// <summary>
    /// Possui todas as tabelas do banco bd_larc em formato de classes.
    /// </summary>
    namespace Tabelas
    {
        public class Item
        {
            /// <summary>
            /// Se a classe for instanciada para inserir no banco, o valor de Cod_it deverá ser 0(zero).
            /// </summary>
            public Item(UInt16 Cod_it, string Und, string Tipo, string Descricao, float Valor, string Categoria, byte Faixa_etaria)
            {
                cod_it = Cod_it;
                und = Und;
                tipo = Tipo;
                descricao = Descricao;
                valor = Valor;
                categoria = Categoria;
                faixa_etaria = Faixa_etaria;
            }
            public Item()
            {
                cod_it = 0;
                und = string.Empty;
                tipo = string.Empty;
                descricao = string.Empty;
                valor = 0;
                categoria = string.Empty;
                faixa_etaria = 0;
            }
            public UInt16 cod_it { get; set; }
            public string und { get; set; }
            public string tipo { get; set; }
            public string descricao { get; set; }
            public float valor { get; set; }
            public string categoria { get; set; }
            public byte faixa_etaria { get; set; }
        }

        public class Casa
        {
            /// <summary>
            /// Se a classe for instanciada para inserir no banco, o valor de Cod_casa deverá ser 0(zero).
            /// </summary>
            /// <param name="Cod_casa"></param>
            /// <param name="Nome"></param>
            public Casa(byte Cod_casa, string Nome)
            {
                cod_casa = Cod_casa;
                nome = Nome;
            }
            public Casa()
            {
                cod_casa = 0;
                nome = string.Empty;
            }
            public byte cod_casa { get; set; }
            public string nome { get; set; }
        }

        public class Requisita
        {
            /// <summary>
            /// Se a classe for instanciada para inserir no banco o valor de Cod_it deverá ser 0(zero).
            /// </summary>
            public Requisita(int Cod_req, DateTime Data, UInt16 Qtd, byte Cod_casa, UInt16 Cod_it)
            {
                cod_req = Cod_req;
                data = Data;
                qtd = Qtd;
                cod_casa = Cod_casa;
                cod_it = Cod_it;
            }
            public Requisita()
            {
                cod_req = 0;
                data = DateTime.Now;
                qtd = 0;
            }

            public int cod_req { get; set; }
            public DateTime data { get; set; }
            public UInt16 qtd { get; set; }
            public byte cod_casa { get; set; }
            public UInt16 cod_it { get; set; }

        }

        public class Doador
        {
            public Doador(UInt16 Cod_doador, string Email, string Telefone, string Telefone2)
            {
                cod_doador = Cod_doador;
                email = Email;
                telefone = Telefone;
                telefone2 = Telefone2;
            }
            public Doador()
            {
                cod_doador = 0;
                email = string.Empty;
                telefone = string.Empty;
                telefone2 = string.Empty;
            }
            public UInt16 cod_doador { get; set; }
            public string email { get; set; }
            public string telefone { get; set; }
            public string telefone2 { get; set; }
        }

        public class Doacao
        {
            public Doacao(UInt16 Cod_doacao, DateTime Data, float Valor_total, UInt16 Cod_doador)
            {
                cod_doacao = Cod_doacao;
                data = Data;
                valor_total = Valor_total;
                cod_doador = Cod_doador;
            }
            public Doacao()
            {
                cod_doacao = 0;
                data = DateTime.Now;
                valor_total = 0;
            }
            public UInt16 cod_doacao { get; set; }
            public DateTime data { get; set; }
            public float valor_total { get; set; }
            public UInt16 cod_doador { get; set; }
        }

        public class DoacxItem
        {
            public DoacxItem(UInt16 Qtd, UInt16 Cod_it, UInt16 Cod_doacao)
            {
                qtd = Qtd;
                cod_it = Cod_it;
                cod_doacao = Cod_doacao;
            }
            public DoacxItem() { }
            public UInt16 qtd { get; set; }
            public UInt16 cod_it { get; set; }
            public UInt16 cod_doacao { get; set; }
        }

        public class Nao_parceiro
        {
            public Nao_parceiro(string Nome, string Cpf, UInt16 Cod_doador)
            {
                nome = Nome;
                cpf = Cpf;
                cod_doador = Cod_doador;
            }
            public Nao_parceiro()
            {
                nome = string.Empty;
                cpf = string.Empty;
            }
            public string nome { get; set; }
            public string cpf { get; set; }
            public UInt16 cod_doador { get; set; }
        }

        public class Parceiro
        {
            public Parceiro(string Razao_social, string Cnpj, UInt16 Cod_doador)
            {
                razao_social = Razao_social;
                cnpj = Cnpj;
                cod_doador = Cod_doador;
            }
            public Parceiro()
            {
                razao_social = string.Empty;
                cnpj = string.Empty;
            }
            public string razao_social { get; set; }
            public string cnpj { get; set; }
            public UInt16 cod_doador { get; set; }
        }

    }
}
