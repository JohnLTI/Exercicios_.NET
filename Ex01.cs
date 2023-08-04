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
            decimal qmin = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade máxima do produto: ");
            decimal qmax = int.Parse(Console.ReadLine());
            var media = Math.Floor((qmin + qmax) / 2);
            Console.WriteLine(value: $"O estoque médio do produto é {media}");


            do
            {
                Console.WriteLine("Aperte ESC para voltar ao Menu inicial!");
            }

            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Menu.View();
        }
    }
}