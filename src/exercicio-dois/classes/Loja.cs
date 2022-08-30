using System;
using System.Collections.Generic;

namespace exercicio_dois.classes
{
    public class Loja
    {
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public List<Livro> Livros { get; set; }
        public List<VideoGame> VideoGames { get; set; }

        public Loja()
        {
        }

        public Loja(string nome, string cnpj, List<Livro> livros)
        {
            Nome = nome;
            CNPJ = cnpj;
            Livros = livros;
        }

        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videogames)
        {
            Nome = nome;
            CNPJ = cnpj;
            Livros = livros;
            VideoGames = videogames;
        }

        public string ListaLivros()
        {
            if (Livros != null)
            {
                Console.WriteLine("------------------------------------------");
                foreach (var livro in Livros)
                    return livro.ToString();
            }

            return "------------------------------------------\nA loja não tem livros no seu estoque";
        }

        public string ListaVideoGames()
        {
            if (VideoGames != null)
            {
                Console.WriteLine("------------------------------------------");
                foreach (var videoGame in VideoGames)
                {
                    Console.WriteLine(videoGame);
                }

            }

            return "------------------------------------------\nA loja não tem vídeo-games no seu estoque";
        }

        public string CalculaPatrimonio()
        {
            var patrimonio = 0.00;

            foreach (var livro in Livros)
                patrimonio += livro.Preco * livro.Qtd;

            foreach (var videoGame in VideoGames)
                patrimonio += videoGame.Preco * videoGame.Qtd;

            return $"------------------------------------------\nO patrimônio da loja: {Nome} é de R$ {patrimonio}.";
        }
    }
}