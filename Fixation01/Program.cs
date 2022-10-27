using System.Globalization;

namespace FixationExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string product1 = "Computador";
            string product2 = "Mesa de escritório";

            byte age = 30;
            int code = 5290;
            char gender = 'M';

            double price1 = 2100.0;
            double price2 = 650.50;
            double measurement = 53.234567;

            Console.WriteLine("--------------------");
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{product1}, cujo preço é R$ {price1:F2}");
            Console.WriteLine($"{product2}, cujo preço é R$ {price2:F2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {age} anos de idade, código {code} e gênero: {gender}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {measurement:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {measurement:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + measurement.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("--------------------");
        }
    }
}
