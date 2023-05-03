using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBarConsoleApp1
{
    public class TelaPrincipal
    {
        public string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Seja bem-vindo(a) ao Bar da Galera!");
            Console.WriteLine("Digite 1 para chamar um garçom.");
            Console.WriteLine("Digite 2 para escolher uma mesa.");
            Console.WriteLine("Digite 3 para fazer um pedido.");

            Console.WriteLine("Digite S para sair");

            string opcao = Convert.ToString(Console.Read());
            return opcao;
        }
    }
}
