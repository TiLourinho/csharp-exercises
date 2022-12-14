using System.Globalization;

namespace FixationExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            A - Fazer um programa para ler os valores da largura e altura de um retângulo. Em
            seguida, mostrar na tela o valor de sua área, perímetro e diagonal.

            Digite a largura e altura do retângulo:
            3.00
            4.00

            AREA = 12.00
            PERÍMETRO = 14.00
            DIAGONAL = 5.00
            */

            Rectangle();

            /*
            B - Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto).
            Em seguida, mostrar os dados do funcionário (nome e salário líquido). Em seguida, aumentar o salário
            do funcionário com base em uma porcentagem dada (somente o salário bruto é afetado pela porcentagem)
            e mostrar novamente os dados do funcionário.

            Nome: Joao Silva
            Salário bruto: 6000.00
            Imposto: 1000.00

            Funcionário: Joao Silva, $ 5000.00

            Digite a porcentagem para aumentar o salário: 10.0

            Dados atualizados: Joao Silva, $ 5600.00
            */

            EmployeeInfo();

            /*
            C - Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
            (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
            ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
            para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
            este problema.

            Nome do aluno: Alex Green
            Digite as três notas do aluno:
            27.00
            31.00
            32.00

            NOTA FINAL = 90.00
            APROVADO
            */

            StudendInfo();
        }

        static void Rectangle()
        {
            Rectangle rectangle = new();

            Console.WriteLine("Digite a largura e altura do retângulo:");
            rectangle.width = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            rectangle.height = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine($"\nAREA = {rectangle.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERÍMETRO = {rectangle.Perimeter().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {rectangle.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }

        static void EmployeeInfo()
        {
            Employee employee = new();

            Console.Write("Nome: ");
            employee.name = Console.ReadLine();
            Console.Write("Salário bruto: ");
            employee.grossSalary = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            employee.tax = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine($"\nFuncionário: {employee.name}, R$ {employee.NetSalary().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double percentage = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            employee.IncreaseSalary(percentage);

            Console.WriteLine($"\nDados atualizados: {employee.name}, R$ {employee.NetSalary().ToString("F2", CultureInfo.InvariantCulture)}");
        }

        static void StudendInfo()
        {
            Student student = new();

            Console.Write("Nome do aluno: ");
            student.name = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            student.firstQuarter = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            student.secondQuarter = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            student.thirdQuarter = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine($"\nNOTA FINAL = {student.FinalGrade().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{student.IsApproved()}");
            Console.WriteLine($"FALTARAM {(60 - student.FinalGrade()).ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
        }
    }
}