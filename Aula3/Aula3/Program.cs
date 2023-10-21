using System;

namespace Aula3
{
    public class Program
    {
        /// <summary>
        /// Função Principal
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int x = EntradaDeValor();
            CalculaFDeX(x);
            Console.ReadLine();
        }

        /// <summary>
        /// Recebo o valor de x
        /// </summary>
        /// <returns>Valor de x</returns>
        /// 
        public static int EntradaDeValor()
        {
            // comanado de saída
            Console.WriteLine("digite um valor para X.");
            int valorDeX = int.Parse(Console.ReadLine());
            return valorDeX;
        }

        /// <summary>
        /// Calcula o valor de F(x)
        /// </summary>
        /// <param name="x">Coeficiente Angular</param>
        public static void CalculaFDeX(int x)
        {
            int y = 2 * x + 5;
            Console.WriteLine("O valor da função é " + y);
        }
    }
}

