using System;
using exercicio_bonus.screens;

namespace exercicio_bonus.screens
{
    public class ExercicioBonusMainScreen
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("-------------------Exercício bônus----------------------");
            Console.WriteLine();
            Console.WriteLine("Seja bem-vindo ao exercício bônus!");
            Console.WriteLine("O programa fizz buzz verifica se um número é divisível por 3, por 5, ou por 3 e por 5.");
            Console.WriteLine("Caso o número seja divisível por 3, ele escreverá Fizz.");
            Console.WriteLine("Caso o número seja divisível por 5, ele escreverá Buzz.");
            Console.WriteLine("Caso o número seja divisível por 3 e por 5, ele escreverá FizzBuzz.");
            Console.WriteLine();

            EscolhaDoUsuarioScreen.Show();
        }
    }
}