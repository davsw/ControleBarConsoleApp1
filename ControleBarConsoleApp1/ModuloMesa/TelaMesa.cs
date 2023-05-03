using System;

namespace ControleBarConsoleApp1.ModuloMesa
{
    public class TelaMesa
    {
        public string ApresentarMenu()
        {
            Console.WriteLine("Digite 1 para inserir uma mesa.");
            Console.WriteLine("Digite 2 para visualizar uma mesa disponível.");
            Console.WriteLine("Digite 3 para editar uma mesa.");
            Console.WriteLine("Digite 4 para excluir uma mesa.");

            Console.WriteLine("Digite S para sair ");

            string opcao = Console.ReadLine();

            return opcao;
        }

        public void InserirNovaMesa()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de mesa");

            Console.WriteLine("Cadastrando nova mesa...");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.ReadLine();

            Console.WriteLine("Nova mesa cadastrada com sucesso!");

            Console.ResetColor();

            Console.ReadLine();
        }

        public void VisualizarMesa()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de mesa");

            Console.WriteLine("Visualizando mesa...");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.ReadLine();

            Console.WriteLine("Mesa visualizada sucesso!");

            Console.ResetColor();

            Console.ReadLine();
        }

        public void EditarMesa()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de mesa");

            Console.WriteLine("Editando mesa...");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.ReadLine();

            Console.WriteLine("Mesa editada com sucesso!");

            Console.ResetColor();

            Console.ReadLine();
        }

        internal void ExcluirMesa()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de mesa");

            Console.WriteLine("Excluindo mesa...");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.ReadLine();

            Console.WriteLine("Mesa excluida sucesso!");

            Console.ResetColor();

            Console.ReadLine();
        }
    }
}

