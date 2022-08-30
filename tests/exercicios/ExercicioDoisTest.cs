using exercicio_dois.classes;
using Xunit;
using Xunit.Abstractions;
using FluentAssertions;
using System.Collections.Generic;

namespace exercicios
{
    public class ExercicioDoisTest
    {
        private Livro _livro = new Livro("Teste2", 154.9, 250, "Tester", "test", 156);
        private VideoGame _videogameNovo = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
        private VideoGame _videogameUsado = new VideoGame("PS4", 1800, 100, "Sony", "Slim", true);
        private Loja _loja;
        private readonly ITestOutputHelper _output;

        public ExercicioDoisTest(ITestOutputHelper output)
        {
            _output = output;
        }

        public static IEnumerable<object[]> VideogameList
        {
            get
            {
                yield return new object[] { new VideoGame("PS4", 1800, 100, "Sony", "Slim", false) };
                yield return new object[] { new VideoGame("PSA", 1000, 7, "Sony", "Slim", true) };
                yield return new object[] { new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false) };
            }
        }

        public static IEnumerable<object[]> LivroList
        {
            get
            {
                yield return new object[] { new Livro("Teste", 54.9, 25, "Tester", "Test", 227) };
                yield return new object[] { new Livro("Teste2", 154.9, 250, "Tester", "educativo", 156) };
                yield return new object[] { new Livro("Teste3", 1054.9, 2500, "Tester", "Test", 349) };
            }
        }

        [Theory(DisplayName = "Os campos do livro estão preenchidos")]
        [MemberData(nameof(LivroList))]
        public void OsCamposDoLivroEstaoPreenchidos(Livro livro)
        {
            Assert.NotEmpty(livro.Nome);
            Assert.NotNull(livro.Preco);
            Assert.NotNull(livro.Qtd);
            Assert.NotEmpty(livro.Autor);
            Assert.NotEmpty(livro.Tema);
            Assert.NotNull(livro.QtdPag);
            Assert.IsType<Livro>(livro);
        }

        [Fact(DisplayName = "Calcula imposto sobre livro")]
        public void CalculaImpostoSobreLivro()
        {
            _livro = new Livro("Teste2", 154.9, 250, "Tester", "test", 156);

            _livro.Tema.Should().Equals(_livro.Preco * 0.10);
        }

        [Fact(DisplayName = "Calcula imposto sobre livro educativo")]
        public void CalculaImpostoSobreLivroEducativo()
        {
            _livro = new Livro("Teste2", 154.9, 250, "Tester", "educativo", 156);

            _livro.Tema.Should().Equals(0);
        }

        [Fact(DisplayName = "Verifica método ToString do Livro")]
        public void VerificaMetodoToStringDoLivro()
        {
            _livro.ToString().Should().Equals($"Título: {_livro.Nome}, preço: {_livro.Preco}, quantidade: {_livro.Qtd} em estoque.");
        }

        [Theory(DisplayName = "Os campos do videogame estão preenchidos")]
        [MemberData(nameof(VideogameList))]
        public void OsCamposDoVideogameEstaoPreenchidos(VideoGame videogame)
        {
            Assert.NotEmpty(videogame.Nome);
            Assert.NotNull(videogame.Preco);
            Assert.NotNull(videogame.Qtd);
            Assert.NotEmpty(videogame.Marca);
            Assert.NotEmpty(videogame.Modelo);
            Assert.NotNull(videogame.IsUsado);
            Assert.IsType<VideoGame>(videogame);
        }

        [Fact(DisplayName = "Calcula imposto sobre videogame usado")]
        public void CalculaImpostoSobreVideogameUsado()
        {
            _videogameUsado.CalculaImposto().Should().Equals(_videogameUsado.Preco * 0.25);
        }

        [Fact(DisplayName = "Calcula imposto sobre videogame novo")]
        public void CalculaImpostoSobreVideogameNovo()
        {
            _videogameNovo.CalculaImposto().Should().Equals(_videogameUsado.Preco * 0.45);
        }

        [Fact(DisplayName = "Verifica método ToString do Videogame")]
        public void VerificaMetodoToStringDoVideogame()
        {
            _videogameNovo.ToString().Should().Equals($"Título: {_videogameNovo.Nome}, preço: {_videogameNovo.Preco}, quantidade: {_videogameNovo.Qtd} em estoque.");
        }

        [Fact(DisplayName = "Lista os livros do estoque")]
        public void ListaOsLivrosDoEstoque()
        {
            var l1 = new Livro("Harry Potter", 40, 50, "J. K. Rowling", "fantasia", 300);
            var l2 = new Livro("Senhor dos Anéis", 60, 30, "J. R. R. Tolkien", "fantasia", 500);
            var l3 = new Livro("Java POO", 20, 50, "GFT", "educativo", 500);
            var livros = new List<Livro>();

            livros.Add(l1);
            livros.Add(l2);
            livros.Add(l3);

            var loja = new Loja("Americanas", "12345678", livros);

            loja.ListaLivros().Should().NotBeEmpty();
        }

        [Fact(DisplayName = "Lista os livros vazios do estoque")]
        public void ListaOsLivrosVazios()
        {
            var loja = new Loja();
            loja.ListaLivros().Should().Contain("A loja não tem livros");
        }

        [Fact(DisplayName = "Calcula o patrimônio da loja")]
        public void CalculaPatrimonioDaLoja()
        {
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

            var loja = new Loja("Americanas", "12345678", livros, videoGames);

            var patrimonio = 0.00;

            foreach (var livro in livros)
                patrimonio += livro.Preco * livro.Qtd;

            foreach (var videoGame in videoGames)
                patrimonio += videoGame.Preco * videoGame.Qtd;

            loja.CalculaPatrimonio().Should().Equals($"------------------------------------------\nO patrimônio da loja: {loja.Nome} é de R$ {patrimonio}.");
        }
    }
}