using System;

namespace Exercises
{
    class Exercise04
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

            getOddNumbers();
        }

        static void getOddNumbers()
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
    }
}
