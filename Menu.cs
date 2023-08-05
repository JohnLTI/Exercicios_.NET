using System;
using System.Threading;

namespace Exercicios
{
    class Menu
    {
        public static void View()
        {
            Console.Clear();

            Console.WriteLine("--------------------");
            Console.WriteLine("Menu de Exercícios");
            Console.WriteLine("");
            Console.WriteLine("1 - Calculo de Média");
            Console.WriteLine("2 - Conversão Dólar para Real");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("--------------------");

            Console.WriteLine("Escolha um número para visualizar a resolução: ");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0:
                    {
                        Console.Clear();
                        Console.WriteLine("Obrigado por utilizar a aplicação C#!");
                        Thread.Sleep(2000);
                        Environment.Exit(0); break;
                    }

                case 1: Ex01.Calc(); break;
                case 2: Ex02.Calc(); break;

                default: Menu.View(); break;
            }
        }
    }
}