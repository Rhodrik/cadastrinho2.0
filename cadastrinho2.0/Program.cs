using cadastrinho2._0.Conexoes;
using cadastrinho2._0.Entities;
using cadastrinho2._0.Repository;
using cadastrinho2._0.Services;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace cadastrinho2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operacao;
            Console.Clear();
            Menus.MenuInicial();
            operacao = Console.ReadLine();            

            switch (operacao)
            {
                case "1":
                    Console.Clear();
                    Menus.MenudePessoas();
                    string operacao1 = Console.ReadLine();
                    switch (operacao1)
                    {
                        case "1":
                            {
                                //informações vem do usuário
                                string id = DateTime.Now.Ticks.ToString();
                                string nome = "Fernando";
                                string telefone = "4499558858";
                                DateTime datanascimento = DateTime.Now.AddYears(-25);
                                string cpf = "16546513516848";

                                //Classe
                                Pessoa pessoa = new Pessoa(id, nome, telefone, datanascimento, cpf);//Inicialização → Nova instância da classe
                                                                
                                SQLServerConnection conn = new SQLServerConnection();
                                SQLServerRepositoryPessoa repository = new SQLServerRepositoryPessoa(conn);
                                InserirPessoaServico servico = new InserirPessoaServico(conn, repository);
                                servico.Inserir(pessoa);
                            }
                            break;
                        case "2":
                            {
                            }
                            break;
                        case "3":
                            break;
                        case "4":
                            break;
                        case "5":
                            break;
                        case "6":
                            break;
                        case "7":
                            break;
                        case "0":
                            Console.Clear();
                            Console.WriteLine("[Volte Sempre]");
                            Environment.Exit(0);
                            break;
                    }
                    break;
            }
        }
    }
}
