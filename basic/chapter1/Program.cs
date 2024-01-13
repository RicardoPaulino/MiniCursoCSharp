using System;
using System.Windows.Forms;

namespace chapter1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("First post");
            string nome = Console.ReadLine();
            MessageBox.Show(nome);
        }
    }
}