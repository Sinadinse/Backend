using System;
using System.Globalization;

namespace exercício_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = " João ";
            double a, b;
            double pontoFlutuante;
            a = 2.5884;
            b = 2.1235;
            pontoFlutuante = a + b;

            Console.WriteLine(" O valor final que o " + nome + " recebeu foi de: " + pontoFlutuante.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }
    }
}
