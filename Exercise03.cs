using System;

namespace Exercises
{
    class Exercise03
    {
        static void Main(string[] args)
        {
            /*
            A - Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
            incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
            impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.

            Entrada:      Saída:
            2200          Senha Invalida
            1020          Senha Invalida
            2022          Senha Invalida
            2002          Acesso Permitido
            */

            PasswordChecker();

            /*
            B - Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
            cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
            menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).

            Entrada: - Saída:
            2 2        Primeiro
            3 -2       Quarto
            -8 -1      Terceiro
            -7 1       Segundo
            0 2
            */

            FindTheCoordinates();

            /*
            C - Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
            que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
            mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            exemplo.

            Entrada:          Saída:
            8                 MUITO OBRIGADO!
            1                 Álcool: 1
            7                 Gasolina: 2
            2                 Diesel: 0
            2
            4
            */

            GasStation();
        }

        static void PasswordChecker()
        {
            int password;

            while (true)
            {
                Console.Write("Digite sua senha (4 algarismos): ");
                password = int.Parse(Console.ReadLine()!);

                if (password == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }
            }
        }

        static void FindTheCoordinates()
        {
            while (true)
            {
                Console.Write("Digite as coordenadas de X e Y: ");
                string[] coordinates = Console.ReadLine()!.Split(' ');

                int coordinateX = int.Parse(coordinates[0]);
                int coordinateY = int.Parse(coordinates[1]);

                if (coordinateX == 0 || coordinateY == 0)
                {
                    Console.WriteLine(" ");
                    break;
                }
                else if (coordinateX > 0 && coordinateY > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (coordinateX < 0 && coordinateY > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (coordinateX < 0 && coordinateY < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Quarto");
                }
            }
        }

        static void GasStation()
        {
            int gasolineCounter = 0;
            int ethanolCounter = 0;
            int dieselCounter = 0;

            while (true)
            {
                Console.WriteLine("Posto de Gasolina");
                Console.WriteLine("-----------------");
                Console.WriteLine("1. Álcool\n2. Gasolina\n3. Diesel\n4. FIM");
                Console.WriteLine("Digite o código da sua opção:");
                int chosenOption = int.Parse(Console.ReadLine()!);
                Console.WriteLine();

                if (chosenOption < 0 || chosenOption > 4)
                {
                    Console.WriteLine("Código inválido!\n");
                    //Console.WriteLine("1. Álcool\n2. Gasolina\n3. Diesel\n4. FIM");
                    //Console.Write("Digite o código da sua opção: ");
                }
                else if (chosenOption == 1)
                {
                    ethanolCounter++;
                }
                else if (chosenOption == 2)
                {
                    gasolineCounter++;
                }
                else if (chosenOption == 3)
                {
                    dieselCounter++;
                }
                else
                {
                    Console.WriteLine("MUITO OBRIGADO!\n");
                    Console.WriteLine($"Álcool: {ethanolCounter}");
                    Console.WriteLine($"Gasolina: {gasolineCounter}");
                    Console.WriteLine($"Diesel: {dieselCounter}");
                    break;
                }
            }
        }
    }
}
