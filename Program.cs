using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            string digitado;
           Console.WriteLine("digite algo...");
           digitado = Console.ReadLine();
           Console.WriteLine(digitado.ToUpper());
        }
    }
}
