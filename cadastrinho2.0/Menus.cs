using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastrinho2._0
{
    public class Menus
    {
        public static void MenuInicial()
        {
            Console.WriteLine("[----------------Seja Bem Vindo----------------]");
            Console.WriteLine(
                "[Que tela deseja acessar ?]\n " +
                "[1] [Pessoas]\n " +
                //"[2] [Produtos (TODO)]\n " +
                "[0] [Sair]"
                );
        }
        public static void MenudePessoas()
        {
            Console.WriteLine("[----------------Pessoas----------------]");
            Console.WriteLine(
                "[Que operação deseja efetuar ?]\n " +
                "[1] [Incluir]\n " +
                "[2] [Exibir]\n " +
                "[3] [Deletar]\n " +
                "[4] [Pesquisar]\n " +
                "[5] [Alterar]\n " +
                "[6] [Voltar]\n" +
                "[0] [Sair]"
                );
        }
        public static void MenudeProdutos()
        {
            Console.WriteLine("[----------------Produtos----------------]");
            Console.WriteLine(
                "[Que operação deseja efetuar ?]\n " +
                "[1] [Incluir]\n " +
                "[2] [Exibir]\n " +
                "[3] [Deletar]\n " +
                "[4] [Pesquisar]\n " +
                "[5] [Alterar]\n " +
                "[6] [Voltar]\n" +
                "[7] [Sair]"
                );
        }
    }
}