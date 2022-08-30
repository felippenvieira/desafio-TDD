using System;
using exercicio_um.classes;

namespace exercicio_um.screens
{
    public class ExercicioUmMainScreen
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("-------------------Exercício um-------------------------");
            Console.WriteLine();
            Console.WriteLine("Olá! Seja bem-vindo ao nosso simulador de veículo.");
            Console.WriteLine();
            Console.WriteLine("Você está no veículo. O que deseja fazer?");

            var vehicle = new Vehicle();

            MenuScreen.Show(vehicle);

            EscolhaOpcaoScreen.Show(vehicle);
        }
    }
}