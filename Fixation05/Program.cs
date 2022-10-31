using System.Globalization;

namespace FixationExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
            uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
            que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe CurrencyConverter
            para ser responsável pelos cálculos.

            Exemplo:
                Qual é a cotação do dólar? 3.10
                Quantos dólares você vai comprar? 200.00
                Valor a ser pago em reais = 657.20
            */
            Console.Write("Qual é a cotação do dólar? ");
            double quote = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quantity = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            double cost = CurrencyConverter.Converter(quote, quantity);

            Console.WriteLine($"Valor a ser pago em reais = {cost.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
        }
    }
}