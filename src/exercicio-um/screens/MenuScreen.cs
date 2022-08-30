using System;
using exercicio_um.classes;

namespace exercicio_um.screens
{
    public class MenuScreen
    {
        public static void Show(Vehicle vehicle)
        {
            Console.WriteLine();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Acelerar");
            Console.WriteLine("2 - Abastecer");
            Console.WriteLine("3 - Frear");
            Console.WriteLine("4 - Pintar");
            Console.WriteLine("5 - Ligar");
            Console.WriteLine("6 - Desligar");
            Console.WriteLine();
            Console.WriteLine("0 - Voltar ao menu anterior");
            Console.WriteLine();
            Console.WriteLine($"Velocidade: {vehicle.Velocidade} | Cor: {vehicle.Cor} | Combustível {vehicle.litrosCombustivel}/60");
        }
    }
}