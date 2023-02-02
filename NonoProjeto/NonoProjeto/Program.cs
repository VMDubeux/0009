using System;
namespace Exercicio
{
    class NonoProjeto
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a localização (X e Y). Saiba em qual dos quatro quadrantes você está!");
            Console.WriteLine("Primeiro, diga o valor de X:");
            float coord_X = float.Parse(Console.ReadLine());
            Console.WriteLine("Muito bem! Qual o valor de Y?");
            float coord_Y = float.Parse(Console.ReadLine());
            if (coord_X == 0 && coord_Y == 0)
            {
                Console.WriteLine("Você está no ponto de origem! Logo, ainda não está em nenhum dos quatro Quadrantes!");
            }
            else if (coord_X > 0 && coord_Y > 0)
            {
                Console.WriteLine("Você está no Quadrante 1!");
            }
            else if (coord_X < 0 && coord_Y > 0)
            {
                Console.WriteLine("Você está no Quadrante 2!");
            }
            else if (coord_X < 0 && coord_Y < 0) {
                Console.WriteLine("Você está no Quadrante 3!");
            }
            else
            {
                Console.WriteLine("Você está no Quadrante 4!");
            }
        }
    }
}