using System.Globalization;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            double PI = 3.14159;

            /*
            A - Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            mensagem explicativa, conforme exemplos:

            Entrada: 10 30 - Saída: SOMA = 40

            Entrada: -30 10 - Saída: SOMA = -20

            Entrada: 0 0 - Saída: SOMA = 0
            */

            Console.WriteLine("Digite um número:");
            int number1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite outro número:");
            int number2 = int.Parse(Console.ReadLine()!);

            int sum = number1 + number2;
            Console.WriteLine($"SOMA = {sum}");

            /*
            B - Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
            casas decimais conforme exemplos:
            
            Fórmula da área: area = π . raio2
            Considere o valor de π = 3.14159

            Entrada: 2.00 - Saída: A=12.5664

            Entrada: 100.64 - Saída: A=31819.3103

            Entrada: 150.00 - Saída: A=70685.7750
            */

            Console.WriteLine("Digite o valor do raio de um círculo:");
            double radius = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            double area = PI * (Math.Pow(radius, 2));

            Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");

            /*
            C - Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
            de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

            Entrada: 5 6 7 8 - Saída: DIFERENCA = -26

            Entrada: 5 6 -7 8 - Saída: DIFERENCA = 86
            */

            Console.WriteLine("Digite 4 valores numéricos (na mesma linha):");
            string[] inputNumbers = Console.ReadLine()!.Split(' ');

            int numberA = int.Parse(inputNumbers[0]);
            int numberB = int.Parse(inputNumbers[1]);
            int numberC = int.Parse(inputNumbers[2]);
            int numberD = int.Parse(inputNumbers[3]);

            int firstProduct = numberA * numberB;
            int secondProduct = numberC * numberD;
            int difference = firstProduct - secondProduct;

            Console.WriteLine($"DIFERENCA = {difference}");

            /*
            D - Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
            hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
            decimais.

            Entrada: 25 100 5.50 - Saída: NUMBER = 25
                                          SALARY = U$ 550.00

            Entrada: 1 200 20.50 - Saída: NUMBER = 25
                                          SALARY = U$ 4100.00

            Entrada: 6 145 15.55 - Saída: NUMBER = 6
                                          SALARY = U$ 2254.75
            */

            Console.WriteLine("Calculadora de Salários");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Número do funcionário:");
            int employeeNumber = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Horas trabalhadas:");
            int workedHours = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Valor da hora trabalhada:");
            double workedHourValue = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            double salary = (double)workedHours * workedHourValue;
            Console.WriteLine("-----------------------");
            Console.WriteLine($"NUMBER = {employeeNumber}");
            Console.WriteLine($"SALARY = U$ {salary.ToString("F2", CultureInfo.InvariantCulture)}");

            /*
            E - Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

            Entrada: 12 1 5.30 - Saída: VALOR A PAGAR: R$ 15.50
                     16 2 5.10

            Entrada: 13 2 15.30 - Saída: VALOR A PAGAR: R$ 51.40
                     161 4 5.20

            Entrada: 1 1 15.10 - Saída: VALOR A PAGAR: R$ 30.20
                     2 1 15.10
            */

            Console.WriteLine("Carrinho de Compras");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Código da peça:");
            int part1Code = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Quantidade:");
            int part1Quantity = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Valor da peça:");
            double part1Price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("Código da peça:");
            int part2Code = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Quantidade:");
            int part2Quantity = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Valor da peça:");
            double part2Price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            double part1TotalPrice = part1Quantity * part1Price;
            double part2TotalPrice = part2Quantity * part2Price;
            double totalPrice = part1TotalPrice + part2TotalPrice;
            Console.WriteLine("-----------------------");
            Console.WriteLine($"VALOR A PAGAR: R$ {totalPrice.ToString("F2", CultureInfo.InvariantCulture)}");

            /*
            F - Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
            mostre:

            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B.

            Entrada: 3.0 4.0 5.2 - Saída: TRIANGULO: 7.800
                                          CIRCULO: 84.949
                                          TRAPEZIO: 18.200
                                          QUADRADO: 16.000
                                          RETANGULO: 12.000

            Entrada: 12.7 10.4 15.2 - Saída: TRIANGULO: 96.520
                                          CIRCULO: 725.833
                                          TRAPEZIO: 175.560
                                          QUADRADO: 108.160
                                          RETANGULO: 132.080
            */

            Console.WriteLine("Calculadora de Áreas");
            Console.WriteLine("-----------------------");

            Console.WriteLine("Valor de A, B e C:");

            string[] variables = Console.ReadLine()!.Split(' ');

            double varA = double.Parse(variables[0], CultureInfo.InvariantCulture);
            double varB = double.Parse(variables[1], CultureInfo.InvariantCulture);
            double varC = double.Parse(variables[2], CultureInfo.InvariantCulture);

            double triangleArea = (varA * varC) / 2;
            double circleArea = PI * Math.Pow(varC, 2);
            double trapezeArea = ((varA + varB) / 2) * varC;
            double squareArea = Math.Pow(varB, 2);
            double rectangleArea = varA * varB;

            Console.WriteLine("-----------------------");
            Console.WriteLine($"TRIANGULO: {triangleArea.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {circleArea.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {trapezeArea.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {squareArea.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {rectangleArea.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
