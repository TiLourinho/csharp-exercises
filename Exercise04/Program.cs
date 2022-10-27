using System;
using System.Globalization;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            A - Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
            X, se for o caso.

            Entrada:      Saída:
            8             1
                          3
                          5
                          7
            */

            GetOddNumbers();

            /*
            B - Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
            essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

            Entrada:      Saída:
            5             2 in
            14            3 out
            123
            10
            -25
            32
            */

            InOrOut();

            /*
            C - Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
            conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            peso 5.

            Entrada:           Saída:
            3
            6.5 4.3 6.2        5.7
            5.1 4.2 8.1        6.3
            8.0 9.0 10.0       9.3
            */

            WeightedAverage();

            /*
            D - Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
            segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".

            Entrada:      Saída:
            3             
            3 -2          - 1.5
            -8 0          divisao impossivel
            0 8           0.0
            */

            TheDivision();

            /*
            E - Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
            Lembrando que, por definição, fatorial de 0 é 1.

            Entrada:      Saída:
            4             24             
            1             1
            5             120
            0             1
            */

            Factorial();

            /*
            F - Ler um número inteiro N e calcular todos os seus divisores.

            Entrada:      Saída:
            6             1             
                          2
                          3
                          6
            */

            Dividers();

            /*
            G - Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
            começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
            exemplo.

            Entrada:      Saída:
            5             1 1 1             
                          2 4 8
                          3 9 27
                          4 16 64
                          5 25 125
            */

            SquaresAndCubes();
        }

        static void GetOddNumbers()
        {
            Console.WriteLine("Digite um número:");
            int limitNumber = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= limitNumber; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }

        static void InOrOut()
        {
            Console.Write("Digite o número de entradas desejadas: ");
            int inputNumber = int.Parse(Console.ReadLine()!);

            int counterIn = 0;
            int counterOut = 0;

            for (int i = 1; i <= inputNumber; i++)
            {
                Console.Write("Digite um número para saber se ele está ou não no intervalo [10, 20]: ");
                int input = int.Parse(Console.ReadLine()!);

                if (input >= 10 && input <= 20)
                {
                    counterIn++;
                }
                else
                {
                    counterOut++;
                }
            }

            Console.WriteLine($"\n{counterIn} in");
            Console.WriteLine($"{counterOut} out");
        }

        static void WeightedAverage()
        {
            Console.Write("Digite o número de entradas desejadas: ");
            int inputNumber = int.Parse(Console.ReadLine()!);

            double result = 0;

            for (int i = 1; i <= inputNumber; i++)
            {
                Console.Write("Digite 1 valor para que a média ponderada seja calculada: ");
                double input = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                if (i == 1)
                {
                    result += input * 2;
                }
                else if (i == 2)
                {
                    result += input * 3;
                }
                else
                {
                    result += input * 5;
                }
            }

            result /= (2 + 3 + 5);
            Console.WriteLine($"{result.ToString("F1", CultureInfo.InvariantCulture)}"); ;
        }

        static void TheDivision()
        {
            Console.Write("Digite o número de entradas desejadas: ");
            int inputNumber = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= inputNumber; i++)
            {
                Console.Write("Digite um par de números para que a divisão seja feita: ");
                string[] input = Console.ReadLine()!.Split();

                double inputA = double.Parse(input[0], CultureInfo.InvariantCulture);
                double inputB = double.Parse(input[1], CultureInfo.InvariantCulture);

                double result;

                if (inputB == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    result = inputA / inputB;
                    Console.WriteLine($"{result.ToString(CultureInfo.InvariantCulture)}"); ;
                }
            }
        }

        static void Factorial()
        {
            Console.Write("Digite um número inteiro para que seja feito seu fatorial: ");
            int inputNumber = int.Parse(Console.ReadLine()!);

            int factorial = 1;

            for (int i = 1; i <= inputNumber; i++)
            {
                if (inputNumber == 0)
                {
                    factorial = 1;
                    Console.WriteLine(factorial);
                }
                else
                {
                    factorial *= i;
                }
            }

            Console.WriteLine(factorial);
        }

        static void Dividers()
        {
            Console.Write("Digite um número para encontrar todos os seus divisores: ");
            int inputNumber = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= inputNumber; i++)
            {
                if (inputNumber % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void SquaresAndCubes()
        {
            Console.Write("Digite um número: ");
            int inputNumber = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= inputNumber; i++)
            {
                double square = Math.Pow(i, 2);
                double cube = Math.Pow(i, 3);
                Console.WriteLine($"Linha {i}: {square} {cube}");
            }
        }
    }
}
