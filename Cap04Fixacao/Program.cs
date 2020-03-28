using System;
using System.Globalization;

namespace Cap04Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorDeMoeda cvm = new ConversorDeMoeda();

            Console.Write("Qual a cotação do dólar? ");
            cvm.Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            cvm.Quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais {0}", cvm.ValorPago().ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
