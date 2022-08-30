using System;
using System.Collections.Generic;
using exercicio_dois.classes;

namespace exercicio_dois.screens
{
    public class ExercicioDoisMainScreen
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("-------------------Exercício dois-----------------------");
            Console.WriteLine();
            var l1 = new Livro("Harry Potter", 40, 50, "J. K. Rowling", "fantasia", 300);
            var l2 = new Livro("Senhor dos Anéis", 60, 30, "J. R. R. Tolkien", "fantasia", 500);
            var l3 = new Livro("Java POO", 20, 50, "GFT", "educativo", 500);

            var ps4 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
            var ps4Usado = new VideoGame("PSA", 1000, 7, "Sony", "Slim", true);
            var xbox = new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);

            var livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);
            livros.Add(l3);

            var videoGames = new List<VideoGame>();
            videoGames.Add(ps4);
            videoGames.Add(ps4Usado);
            videoGames.Add(xbox);

            var americanas = new Loja("Americanas", "12345678", livros, videoGames);

            l2.CalculaImposto();
            l3.CalculaImposto();

            ps4Usado.CalculaImposto();
            ps4.CalculaImposto();

            Console.WriteLine(americanas.ListaLivros());
            Console.WriteLine(americanas.ListaVideoGames());
            Console.WriteLine(americanas.CalculaPatrimonio());
            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal...");
            Console.ReadLine();
        }
    }
}