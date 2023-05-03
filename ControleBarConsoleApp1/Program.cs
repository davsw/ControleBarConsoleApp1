using ControleBarConsoleApp1.ModuloGarcom;
using ControleBarConsoleApp1.ModuloMesa;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ControleBarConsoleApp1
{
    public class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                string opcao = new TelaPrincipal().ApresentarMenu();


                
                if (opcao != "S" ||  opcao != "1" || opcao != "2" || opcao != "3")
                {
                    Console.Clear();
                    Console.WriteLine("Operação inválida...");
                    continue;
                }
                if (opcao == "S" || opcao == "s")
                {
                    //sair do sistema
                    break;
                }
                if (opcao == "1") //submenu garçom
                {
                    TelaGarcom telaGarcom = new TelaGarcom();

                    string opcaoGarcom = telaGarcom.ApresentarMenu();

                    if (opcaoGarcom == "1")
                    {
                        telaGarcom.InserirNovoGarcom();
                    }
                    else if (opcaoGarcom == "2")
                    {
                        telaGarcom.VisualizarGarcom();
                    }
                    else if (opcaoGarcom == "3")
                    {
                        telaGarcom.EditarGarcom();
                    }
                    else if (opcaoGarcom == "4")
                    {
                        telaGarcom.ExcluirGarcom();
                    }


                    continue;
                }
                else if (opcao == "2") //submenu mesa
                {
                    TelaMesa telaMesa = new TelaMesa();
                    telaMesa.ApresentarMenu();
                    string opcaoMesa = telaMesa.ApresentarMenu();
                    if(opcaoMesa == "1")
                    {
                        telaMesa.InserirNovaMesa();
                    }
                    else if (opcaoMesa == "2")
                    {
                        telaMesa.VisualizarMesa();
                    }
                    else if (opcaoMesa == "3")
                    {
                        telaMesa.EditarMesa();
                    }
                    else if (opcaoMesa == "4")
                    {
                        telaMesa.ExcluirMesa();
                    }
                    continue;
                }

                else if (opcao == "3") //submenu pedido
                {
                    TelaProduto telaProduto = new TelaProduto();
                    telaProduto.ApresentarMenu();

                    continue;
                }
            }
        }
    }
}

