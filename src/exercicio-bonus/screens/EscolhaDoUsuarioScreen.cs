using System;
using System.Threading;
using exercicio_bonus.classes;

namespace exercicio_bonus.screens
{
    public class EscolhaDoUsuarioScreen
    {
        public static void Show()
        {
            Console.WriteLine();
            Console.Write("Escolha um número: ");
            var escolhaDoUsuario = int.Parse(Console.ReadLine());
            FizzBuzz fizzBuzz = new FizzBuzz();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"O número {escolhaDoUsuario} é {fizzBuzz.FizzBuzzer(escolhaDoUsuario)}");
            Thread.Sleep(2000);
            JogarNovamenteScreen.Show();
        }
    }
}