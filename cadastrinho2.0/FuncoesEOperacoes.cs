using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastrinho2._0
{
    internal class FuncoesEOperacoes
    {
        //Parametro do cadastro de Produtos/////\
        public int Id { get; set; }
        public string Nome { get; set; }
        public double PrecoUnidade { get; set; }
        public int Quantia { get; set; }
        ///////////////////////////////////////\/

        //Parametro do cadastro de Pessoas//////\
        public string Nomeps { get; set; }
        public int Cpf { get; set; }
        public int DatadeNascimento { get; set; }
        public int Telefone { get; set; }
        ///////////////////////////////////////\/

        //Metodos de Inclusão de Produtos////////////////////////////////////////////////\
        public static void IncluirProduto(FuncoesEOperacoes item)
        {
            string strSQL;
            SqlConnection conexao;
            SqlCommand comando;
            conexao = new SqlConnection("Data Source=DESKTOP-2KT82C9\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            Console.WriteLine("[Agora entre com o novo Id do item]");
            item.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("[Agora entre com o novo nome do item]");
            item.Nome = Console.ReadLine();
            Console.WriteLine("[Agora entre com o novo preço do item]");
            item.PrecoUnidade = double.Parse(Console.ReadLine());
            Console.WriteLine("[Agora entre com a nova quantia do item]");
            item.Quantia = int.Parse(Console.ReadLine());
            strSQL = "INSERT INTO todosdados (Id, Nome, PrecoUnidade, Quantia) VALUES (@id, @nome, @precounidade, @Quantia)";
            conexao.Open();

            comando = new SqlCommand(strSQL, conexao);
            comando.Parameters.AddWithValue("@id", item.Id);
            comando.Parameters.AddWithValue("@nome", item.Nome);
            comando.Parameters.AddWithValue("@precounidade", item.PrecoUnidade);
            comando.Parameters.AddWithValue("@Quantia", item.Quantia);
        }
        ////////////////////////////////////////////////////////////////////////////////\/

        //Metodos de Inclusão de Pessoas////////////////////////////////////////////////\
        public static void IncluirPessoa(FuncoesEOperacoes human)
        {
            string strSQL;
            SqlConnection conexao;
            SqlCommand comando;
            conexao = new SqlConnection("Data Source=DESKTOP-2KT82C9\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            Console.WriteLine("[Entre com o nome da pessoa]");
            human.Nomeps = Console.ReadLine();
            Console.WriteLine("[Agora entre com o CPF da pessoa]");
            human.Cpf = int.Parse(Console.ReadLine());
            Console.WriteLine("[Agora entre com a data de nascimento da pessoa]");
            human.DatadeNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("[Agora entre com o telefone da pessoa]");
            human.Telefone = int.Parse(Console.ReadLine());
            strSQL = "INSERT INTO todosdados (Nomeps, Cpf, DatadeNascimento, Telefone) VALUES (@nomeps, @cpf, @datadenascimento, @telefone)";
            conexao.Open();

            comando = new SqlCommand(strSQL, conexao);
            comando.Parameters.AddWithValue("@nomeps", human.Nomeps);
            comando.Parameters.AddWithValue("@cpf", human.Cpf);
            comando.Parameters.AddWithValue("@datadenascimento", human.DatadeNascimento);
            comando.Parameters.AddWithValue("@telefone", human.Telefone);
        }
        ///////////////////////////////////////////////////////////////////////////////\/


        //Metodo de Exibição de Produtos/////////////////////////////////////////////////////////////\
        public static void ExibirPodutos(FuncoesEOperacoes item)
        {
            string strSQL;
            SqlConnection conexao;
            SqlCommand comando;
            conexao = new SqlConnection("Data Source=DESKTOP-2KT82C9\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            strSQL = "SELECT * FROM ";
            conexao.Open();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////\/

        //Metodo de Exibição de Pessoas/////////////////////////////////////////////////////////////\
        public static void ExibirPessoas(FuncoesEOperacoes human)
        {
            string strSQL;
            SqlConnection conexao;
            SqlCommand comando;
            conexao = new SqlConnection("Data Source=DESKTOP-2KT82C9\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            strSQL = "SELECT * FROM ";
            conexao.Open();
        }
        ///////////////////////////////////////////////////////////////////////////////////////////\/

        //Metodo de Exclusão de Produtos//////////////////////////////\
        public static void ExcluirProdutos(FuncoesEOperacoes item)
        {

        }
        /////////////////////////////////////////////////////////////\/

        //Metodo de Exclusão de Pessoas//////////////////////////////\
        public static void ExcluirPessoas(FuncoesEOperacoes human)
        {

        }
        ////////////////////////////////////////////////////////////\/

        //Metodo de Pesquisa de Produto/////////////////////////////\
        public static void PesquisarProduto(FuncoesEOperacoes item)
        {
            string strSQL;
            SqlConnection conexao;
            SqlCommand comando;
            conexao = new SqlConnection("Data Source=DESKTOP-2KT82C9\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            strSQL = "SELECT * FROM  WHERE  ";
            conexao.Open();
        }
        ///////////////////////////////////////////////////////////\/

        //Metodo de Pesquisa de Pessoas//////////////////////////////\
        public static void PesquisarPessoa(FuncoesEOperacoes human)
        {
            string strSQL;
            SqlConnection conexao;
            SqlCommand comando;
            conexao = new SqlConnection("Data Source=DESKTOP-2KT82C9\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            strSQL = "SELECT * FROM  WHERE  ";
            conexao.Open();
        }
        ////////////////////////////////////////////////////////////\/

        //Metodos de Alteração de Produtos///////////////////////////////////////////////\
        public static void AlterarProduto(FuncoesEOperacoes item)
        {
            Console.WriteLine("[Agora entre com o novo Id do item]");
            item.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("[Agora entre com o novo nome do item]");
            item.Nome = Console.ReadLine();
            Console.WriteLine("[Agora entre com o novo preço do item]");
            item.PrecoUnidade = double.Parse(Console.ReadLine());
            Console.WriteLine("[Agora entre com a nova quantia do item]");
            item.Quantia = int.Parse(Console.ReadLine());
        }
        //////////////////////////////////////////////////////////////////////////////\/

        //Metodos de Alteração de Pessoas///////////////////////////////////////////////\
        public static void AlterarPessoa(FuncoesEOperacoes human)
        {
            Console.WriteLine("[Agora entre com o novo nome da pessoa]");
            human.Nomeps = Console.ReadLine();
            Console.WriteLine("[Agora entre com o novo CPF da pessoa]");
            human.Cpf = int.Parse(Console.ReadLine());
            Console.WriteLine("[Agora entre com a nova data de nascimento da pessoa]");
            human.DatadeNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("[Agora entre com o novo telefone da pessoa]");
            human.Telefone = int.Parse(Console.ReadLine());
        }
        //////////////////////////////////////////////////////////////////////////////\/

        //Metodo de Saida//////////////////////////////\
        public static void Saida()
        {
            Console.Clear();
            Console.WriteLine("[Volte Sempre]");
            Environment.Exit(0);
        }
        /////////////////////////////////////////////////\/
    }
}
