using System;
using exercicio_tres.classes;

namespace exercicio_tres.screens
{
    public class ExercicioTresMainScreen
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("-------------------Exercício três-----------------------");
            var warrior = new Guerreiro("Arthur", 500, 250, 35000, 250, 1000, 35);
            Console.WriteLine(warrior.AprenderHabilidade("estocada"));
            Console.WriteLine(warrior.Attack());
            Console.WriteLine();

            var mage = new Mago("Gandalf", 250, 500, 35000, 1000, 250, 35);
            Console.WriteLine(mage.AprenderMagia("nevasca"));
            Console.WriteLine(mage.Attack());
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal...");
            Console.ReadLine();
        }
    }
}