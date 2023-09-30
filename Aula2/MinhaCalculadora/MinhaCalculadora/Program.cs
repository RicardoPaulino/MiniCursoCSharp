using System;

namespace MinhaCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Soma(2, 3));
            Console.ReadKey();
        }
        // entrada - processamento - saída
        public static int Soma(int a, int b)
        {
            var funcao = a + b;
            return funcao;
        }
        public static int Subtracao(int a, int b)
        {
            return;
        }

    }
}
