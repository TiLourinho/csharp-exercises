using System;
using System.Globalization;

namespace Exercises
{
    class Exercise02
    {
        static void Main(String[] args)
        {
            /*
            A - Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

            Entrada: -10 - Saída: NEGATIVO

            Entrada: 8 - Saída: NAO NEGATIVO

            Entrada: 0 - Saída: NAO NEGATIVO
            */

            //Console.WriteLine("Digite um número inteiro:");
            //int isNegativeNumber = int.Parse(Console.ReadLine());

            //if (isNegativeNumber >= 0)
            //{
            //    Console.WriteLine("NAO NEGATIVO");
            //}
            //else
            //{
            //    Console.WriteLine("NEGATIVO");
            //}

            /*
            B - Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

            Entrada: 12 - Saída: PAR

            Entrada: -27 - Saída: IMPAR

            Entrada: 0 - Saída: PAR
            */

            //Console.WriteLine("Digite um número inteiro:");
            //int isEvenOrOddNumber = int.Parse(Console.ReadLine());

            //if (isEvenOrOddNumber % 2 == 0)
            //{
            //    Console.WriteLine("PAR");
            //}
            //else
            //{
            //    Console.WriteLine("IMPAR");
            //}

            /*
            C - Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
            Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
            ordem crescente ou decrescente.

            Entrada: 6 24 - Saída: Sao Multiplos

            Entrada: 6 25 - Saída: Nao sao Multiplos

            Entrada: 24 6 - Saída: Sao Multiplos
            */

            Console.WriteLine("Digite o valor inteiro de A e B (na mesma linha):");
            string[] isMultiple = Console.ReadLine().Split(' ');

            int isMultipleA = int.Parse(isMultiple[0]);
            int isMultipleB = int.Parse(isMultiple[1]);

            if (isMultipleA % isMultipleB == 0 || isMultipleB % isMultipleA == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }

}
