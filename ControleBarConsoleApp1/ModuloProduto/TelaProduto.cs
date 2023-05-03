using System;

namespace ControleBarConsoleApp1
{
    public class TelaProduto
    {
        public string ApresentarMenu()
        {
            Console.WriteLine("Digite 1 para inserir um pedido.");
            Console.WriteLine("Digite 2 para visualizar um pedido.");
            Console.WriteLine("Digite 3 para editar um pedido.");
            Console.WriteLine("Digite 4 para excluir um pedido.");

            Console.WriteLine("Digite S para sair ");

            string opcao = Console.ReadLine();

            return opcao;
        }

    }
} 

