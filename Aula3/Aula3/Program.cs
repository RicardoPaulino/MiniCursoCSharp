using System;

namespace Aula3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = EntradaDeValor();
            CalculaFDeX(x);
            Console.ReadLine();
        }

        public static int EntradaDeValor()
        {
            // comanado de saída
            Console.WriteLine("digite um valor para X.");
            int valorDeX = int.Parse(Console.ReadLine());
            return valorDeX;
        }

        public static void CalculaFDeX(int x)
        {
            int y = 2 * x + 5;
            Console.WriteLine("O valor da função é " + y);
        }
    }
}

