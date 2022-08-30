using System;
using exercicio_um.screens;
using exercicio_dois.screens;
using exercicio_tres.screens;
using exercicio_sete.screens;
using exercicio_bonus.screens;

namespace main_program.screens
{
    public class MainScreen
    {
        public static void Show()
        {
            try
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Qual exercício você gostaria de conferir?");
                Console.WriteLine();
                Console.WriteLine("1 - Exercicio Um");
                Console.WriteLine("2 - Exercicio Dois");
                Console.WriteLine("3 - Exercicio Três");
                Console.WriteLine("4 - Exercício Sete");
                Console.WriteLine("5 - Exercicio Bonus");
                Console.WriteLine();
                Console.WriteLine("0 - Sair");
                Console.WriteLine();

                Console.Write("Escolha uma opção: ");
                var option = short.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (option)
                {
                    case 1:
                        ExercicioUmMainScreen.Show();
                        Show();
                        break;
                    case 2:
                        ExercicioDoisMainScreen.Show();
                        Show();
                        break;
                    case 3:
                        ExercicioTresMainScreen.Show();
                        Show();
                        break;
                    case 4:
                        ExercicioSeteMainScreen.Show();
                        Show();
                        break;
                    case 5:
                        ExercicioBonusMainScreen.Show();
                        Show();
                        break;
                    case 0: System.Environment.Exit(0); break;
                    default:
                        Console.Write("Escolha uma opção válida: ");
                        option = short.Parse(Console.ReadLine());
                        break;
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Desculpe, mas sua opção foi inválida.");
                Console.WriteLine("Aperte qualquer tecla para reiniciar...");
                Console.ReadKey();
                Show();
            }
        }
    }
}