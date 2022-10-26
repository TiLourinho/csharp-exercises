using Exercises;
using System.Globalization;

namespace FixationExercises
{
    class Exercise03
    {
        static void Main(string[] args)
        {
            /*
            A - Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
            velha.

            Dados da primeira pessoa:
            Nome: Maria
            Idade: 17

            Dados da segunda pessoa:
            Nome: Joao
            Idade: 16

            Pessoa mais velha: Maria
            */

            IsOlder();

            /*
            B - Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
            médio dos funcionários.

            Dados do primeiro funcionário:
            Nome: Carlos Silva
            Salário: 6300.00

            Dados do segundo funcionário:
            Nome: Ana Marques
            Salário: 6700.00

            Salário médio = 6500.00
            */

            BiggerSalary();
        }

        static void IsOlder()
        {
            Person maria, joao;

            maria = new Person();
            joao = new Person();
            string olderPerson;

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            maria.Name = Console.ReadLine();
            Console.Write("Idade: ");
            maria.Age = int.Parse(Console.ReadLine()!);

            Console.WriteLine("\nDados da segunda pessoa:");
            Console.Write("Nome: ");
            joao.Name = Console.ReadLine();
            Console.Write("Idade: ");
            joao.Age = int.Parse(Console.ReadLine()!);

            if (maria.Age > joao.Age)
            {
                olderPerson = maria.Name!;
            }
            else
            {
                olderPerson = joao.Name!;
            }

            Console.WriteLine($"\nPessoa mais velha: {olderPerson}");
        }

        static void BiggerSalary()
        {
            Employee carlos, ana;

            carlos = new Employee();
            ana = new Employee();
            double averageSalary;

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            carlos.Name = Console.ReadLine();
            Console.Write("Salário: ");
            carlos.Salary = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("\nDados da segunda pessoa:");
            Console.Write("Nome: ");
            ana.Name = Console.ReadLine();
            Console.Write("Salário: ");
            ana.Salary = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            averageSalary = (carlos.Salary + ana.Salary) / 2;

            Console.WriteLine($"\nSalário Médio: R$ {averageSalary.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
