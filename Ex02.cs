using System;
using System.Globalization;
using System.Threading;

namespace Exercicios
{
    class Ex02
    {
        public static void Calc()
        {
            Console.Clear();

            Console.WriteLine("Exercício 02");
            Console.WriteLine("");
            Thread.Sleep(2000);

            decimal dolar = 4.87m;
            Console.WriteLine("Digite um valor em Dólar: ");
            decimal valor = decimal.Parse(Console.ReadLine());

            decimal convert = valor * dolar;

            Console.WriteLine("");
            Console.WriteLine($"O valor atual do dólar é R$ {dolar}");
            Console.WriteLine($"Valor digitado em Dólar: {valor.ToString("C", CultureInfo.CreateSpecificCulture("es-US"))}");
            Console.WriteLine($"Valor convertido em Real é: {convert.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))}");
            Console.WriteLine("");

            do
            {
                Console.WriteLine("Aperte ESC para voltar ao Menu inicial!");
            }

            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Menu.View();
        }
    }
}