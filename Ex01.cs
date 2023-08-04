using System;
using System.Security.Cryptography;

namespace Exercicios
{
    class Ex01
    {
        public static void Calc()
        {
            Console.Clear();

            Console.WriteLine("Informe a quantidade mínima do produto: ");
            int qmin = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade máxima do produto: ");
            int qmax = int.Parse(Console.ReadLine());
            float media = (qmin + qmax) / 2;
            Console.WriteLine($"O estoque médio do produto é {media}");


            do
            {
                Console.WriteLine("Aperte ESC para voltar ao Menu inicial!");
            }

            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Menu.View();
        }
    }
}