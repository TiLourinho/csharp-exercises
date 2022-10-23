using System;
using System.Globalization;

namespace FixationExercises
{
    class Exercise02 {
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu nome completo:");
            string name = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int bedroomsQnt = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double productPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre seu último nome, idade e altura (na mesma linha):");
            string[] personInfo = Console.ReadLine().Split();
            string lastName = personInfo[0];
            int age = int.Parse(personInfo[1]);
            double height = double.Parse(personInfo[2], CultureInfo.InvariantCulture);

            Console.WriteLine("--------------------");

            Console.WriteLine($"Nome: {name}");
            Console.WriteLine($"Número de quartos em casa: {bedroomsQnt}");
            Console.WriteLine($"Preço: R$ {productPrice.ToString("F2")}");
            Console.WriteLine($"Sobrenome: {lastName}");
            Console.WriteLine($"Idade: {age} anos");
            Console.WriteLine($"Altura: {height.ToString("F2", CultureInfo.InvariantCulture)} m");
        }
    }
}