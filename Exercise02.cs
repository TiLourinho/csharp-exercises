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

            Console.WriteLine("Digite um número inteiro:");
            int isNegativeNumber = int.Parse(Console.ReadLine());

            if (isNegativeNumber >= 0)
            {
                Console.WriteLine("NAO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }

            /*
            B - Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

            Entrada: 12 - Saída: PAR

            Entrada: -27 - Saída: IMPAR

            Entrada: 0 - Saída: PAR
            */

            Console.WriteLine("Digite um número inteiro:");
            int isEvenOrOddNumber = int.Parse(Console.ReadLine());

            if (isEvenOrOddNumber % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }

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

            /*
            D - Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
            começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

            Entrada: 16 2 - Saída: O JOGO DUROU 10 HORA(S)

            Entrada: 0 0 - Saída: O JOGO DUROU 24 HORA(S)

            Entrada: 2 16 - Saída: O JOGO DUROU 14 HORA(S)
            */

            Console.WriteLine("Digite a hora inicial e a hora final do jogo:");
            string[] gameInput = Console.ReadLine().Split(' ');

            int gameBeginning = int.Parse(gameInput[0]);
            int gameEnd = int.Parse(gameInput[1]);

            int gameDuration;
            int dayDuration = 24;

            if (gameBeginning > gameEnd)
            {
                gameDuration = (dayDuration - gameBeginning) + gameEnd;
                Console.WriteLine($"O JOGO DUROU {gameDuration} HORA(S)");
            }
            else if (gameBeginning < gameEnd)
            {
                gameDuration = gameEnd - gameBeginning;
                Console.WriteLine($"O JOGO DUROU {gameDuration} HORA(S)");
            }
            else
            {
                Console.WriteLine($"O JOGO DUROU {dayDuration} HORA(S)");
            }

            /*
            E - Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
            seguir, calcule e mostre o valor da conta a pagar.

            CÓDICO     ESPECIFICAÇÃO       PREÇO
            1          Cachorro-quente     R$ 4.00
            2          X-Salada            R$ 4.50
            3          X-Bacon             R$ 5.00
            4          Torrada simples     R$ 2.00
            5          Refrigerante        R$ 1.50

            Entrada: 3 2 - Saída: Total: R$ 10.00

            Entrada: 2 3 - Saída: Total: R$ 13.50
            */

            Console.WriteLine("Digite o código do item e sua quantidade:");
            string[] serviceOrder = Console.ReadLine().Split(' ');

            int itemCode = int.Parse(serviceOrder[0]);
            int itemQuantity = int.Parse(serviceOrder[1]);
            double totalPrice;

            if (itemCode == 1)
            {
                totalPrice = itemQuantity * 4.00;
            }
            else if (itemCode == 2)
            {
                totalPrice = itemQuantity * 4.50;
            }
            else if (itemCode == 3)
            {
                totalPrice = itemQuantity * 5.00;
            }
            else if (itemCode == 4)
            {
                totalPrice = itemQuantity * 2.00;
            }
            else
            {
                totalPrice = itemQuantity * 1.50;
            }

            Console.WriteLine($"Total: R$ {totalPrice.ToString("F2", CultureInfo.InvariantCulture)}");

            /*
            F - Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
            seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
            nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

            Entrada: 25.01 - Saída: Intervalo (25,50]

            Entrada: 25.00 - Saída: Intervalo [0,25]

            Entrada: 100.00 - Saída: Intervalo (75,100]

            Entrada: -25.02 - Saída: Fora de intervalo
            */

            Console.WriteLine("Digite um número decimal:");
            double decimalNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (decimalNumber < 0 || decimalNumber > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (decimalNumber <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (decimalNumber <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (decimalNumber <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }

            /*
            G - Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
            de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
            ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
            Se o ponto estiver na origem, escreva a mensagem “Origem”.
            Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
            situação.

            Entrada: 4.5 -2.2 - Saída: Q4

            Entrada: 0.1 0.1 - Saída: Q1

            Entrada: 0.0 0.0 - Saída: Origem
            */

            Console.WriteLine("Digite os valores de x e y:");
            string[] planeValues = Console.ReadLine().Split(' ');

            double x = double.Parse(planeValues[0], CultureInfo.InvariantCulture);
            double y = double.Parse(planeValues[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }

            /*
            H - Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
            que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
            qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
            Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
            mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.

            RENDA                              IMPOSTO DE RENDA  
            de 0.0 até R$ 2000.00              Isento
            de R$ 2000.01 até R$ 3000.00       8%
            de R$ 3000.01 até R$ 4500.00       18%
            acima de R$ 4500.00                28%

            Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
            salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é
            de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
            duas casas decimais.

            Entrada: 3002.00 - Saída: R$ 80.36

            Entrada: 1701.12 - Saída: Isento

            Entrada: 4520.00 - Saída: R$ 355.60
            */

            Console.WriteLine("Digite um número decimal correspondente à uma salário:");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double tax8Percent = 1000.0 * 0.08;
            double tax18Percent = 1500.0 * 0.18;

            if (salary <= 2000.0)
            {
                Console.WriteLine("Isento");
            }
            else if (salary <= 3000.0)
            {
                double taxSalaryRange1 = (salary - 2000.0) * 0.08;
                double totalTaxes = taxSalaryRange1;
                Console.WriteLine($"R$ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (salary <= 4500.0)
            {
                double taxSalaryRange1 = (salary - 3000.0) * 0.18;
                double taxSalaryRange2 = tax8Percent;
                double totalTaxes = taxSalaryRange1 + taxSalaryRange2;
                Console.WriteLine($"R$ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                double taxSalaryRange1 = (salary - 4500.0) * 0.28;
                double taxSalaryRange2 = tax8Percent;
                double taxSalaryRange3 = tax18Percent;
                double totalTaxes = taxSalaryRange1 + taxSalaryRange2 + taxSalaryRange3;
                Console.WriteLine($"R$ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
