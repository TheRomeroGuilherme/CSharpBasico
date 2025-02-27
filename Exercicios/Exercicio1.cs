using System;

namespace MyApp
{
    internal class Exercicio1
    {
        static void Main(string[] args)
        {
            /*
            Exercicio 1.1
            Fazer um programa para ler o código de uma peça 1,
            o número de peças 1, o valor unitário de cada peça 1, o
            código de uma peça 2, o número de peças 2 e o valor
            unitário de cada peça 2. Calcule e mostre o valor a ser pago.
            */

            Console.Write("Digite o código da peça 1: ");
            int codigoPeca1 = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de peças 1: ");
            int quantidadePeca1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o preço unitário da peça 1: ");
            double precoPeca1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o código da peça 2: ");
            int codigoPeca2 = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de peças 2: ");
            int quantidadePeca2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o preço unitário da peça 2: ");
            double precoPeca2 = double.Parse(Console.ReadLine());

            double valorTotal = (quantidadePeca1 * precoPeca1) + (quantidadePeca2 * precoPeca2);

            Console.WriteLine($"\nValor total a pagar R$ {valorTotal:F2}");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadLine();
        }
    }

}
