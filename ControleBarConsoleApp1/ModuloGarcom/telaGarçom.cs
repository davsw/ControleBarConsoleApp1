using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ControleBarConsoleApp1.ModuloGarcom
{
    public class TelaGarcom
    {
        public string ApresentarMenu()
        {
            Console.Clear();
            Console.WriteLine("Digite 1 para inserir um garçom.");
            Console.WriteLine("Digite 2 para visualizar um garçom disponível.");
            Console.WriteLine("Digite 3 para editar um garçom.");
            Console.WriteLine("Digite 4 para excluir um garçom.");

            Console.WriteLine("Digite S para sair ");

            string opcao = Console.ReadLine();

            return opcao;
        }


        public void InserirNovoGarcom()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de garçom");

            Console.WriteLine("Cadastrando novo garçom...");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.ReadLine();

            Console.WriteLine("Novo garçom cadastrado com sucesso!");

            Console.ResetColor();

            Console.ReadLine();
            
        }

        public void VisualizarGarcom()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de garçom");

            Console.WriteLine("Visualizando garçom...");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.ReadLine();

            Console.WriteLine("Garçons visualizados sucesso!");

            Console.ResetColor();

            Console.ReadLine();

        }
        
        public void EditarGarcom()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de garçom.");
                    
            Console.ForegroundColor = ConsoleColor.Green;

            Console.ReadLine();

            Console.WriteLine("Cadastro de garçom editado com sucesso!");

        }

        public void ExcluirGarcom()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de garçom");

            Console.WriteLine("Excluindo garçom...");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.ReadLine();

            Console.WriteLine("Garçom excluido com sucesso!");

            Console.ResetColor();

            Console.ReadLine();
        }
    }
}
