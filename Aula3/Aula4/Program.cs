using System;

namespace Aula4
{
    public class Program
    {
        static void Main(string[] gabriel)
        {
            Console.WriteLine("Digite uma valor decimal para conversão em binário.");
            int nBinario = int.Parse(Console.ReadLine());

            var binario = ConverterDecimalParaBinario(nBinario);
            Console.WriteLine($"Binário de {nBinario} é: {binario} ");

            Console.ReadKey();
        }

        public static string ConverterDecimalParaBinario(int n)
        {
            if (n == 0) return "0";

            string binario = "";

            while (n > 0)
            {
                int resto = n % 2;
                binario = resto + binario;
                n = n / 2;
            }
            return binario;
        }

    }
}


