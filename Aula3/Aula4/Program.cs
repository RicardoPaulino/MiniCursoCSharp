﻿using System;

namespace Aula4
{
    public class Program
    {
        static void Main(string[] gabriel)
        {
            var binario = ConverterDecimalParaBinario(1240);
            Console.WriteLine("Binário de 1240 é: " + binario);
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


