using System;
using System.Threading;
using exercicio_um.screens;
using exercicio_dois.screens;
using exercicio_tres.screens;
using exercicio_sete.screens;
using main_program.screens;

namespace main_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Olá, professor. Seja muito bem-vindo...");
            Console.WriteLine();
            Thread.Sleep(2000);

            MainScreen.Show();
        }
    }
}
