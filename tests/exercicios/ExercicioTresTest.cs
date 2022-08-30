using exercicio_tres.classes;
using Xunit;
using FluentAssertions;

namespace exercicios
{
    public class ExercicioTresTest
    {
        private Guerreiro _guerreiro = new Guerreiro("guerreiro", 250, 250, 1000, 250, 250, 10);
        private Mago _mago = new Mago("guerreiro", 250, 250, 1000, 250, 250, 10);


        [Fact(DisplayName = "Testa se os campos de guerreiro estão vazios")]
        public void OsCamposDoGuerreiroEstãoPreenchidos()
        {
            _guerreiro.Nome.Should().NotBeEmpty();
            _guerreiro.Vida.Should().BePositive();
            _guerreiro.Mana.Should().BePositive();
            _guerreiro.Inteligencia.Should().BePositive();
            _guerreiro.Forca.Should().BePositive();
            _guerreiro.Level.Should().BePositive();
        }

        [Fact(DisplayName = "Testa se os campos de mago estão vazios")]
        public void OsCamposDoMagoEstãoPreenchidos()
        {
            _mago.Nome.Should().NotBeEmpty();
            _mago.Vida.Should().BePositive();
            _mago.Mana.Should().BePositive();
            _mago.Inteligencia.Should().BePositive();
            _mago.Forca.Should().BePositive();
            _mago.Level.Should().BePositive();
        }

        [Fact(DisplayName = "Testa o ataque do guerreiro")]
        public void TestaAtaqueDoGuerreiro()
        {
            _guerreiro.Attack().Should().Contain("O ataque");
        }

        [Fact(DisplayName = "Testa o ataque do mago")]
        public void TestaAtaqueDoMago()
        {
            _mago.Attack().Should().Contain("O ataque");
        }

        [Theory(DisplayName = "Testa o aprendizado de habilidades do guerreiro")]
        [InlineData("estocada")]
        [InlineData("duplo twist carpado")]
        public void TestaAprendizadoDeHabilidadesDoGuerreiro(string habilidade)
        {
            _guerreiro.AprenderHabilidade(habilidade).Should().Equals($"{_guerreiro.Nome} aprendeu {habilidade}.");
        }

        [Theory(DisplayName = "Testa o aprendizado de magias do mago")]
        [InlineData("magia branca")]
        [InlineData("pó fétido")]
        public void TestaAprendizadoDeMagiasDoMago(string habilidade)
        {
            _mago.AprenderMagia(habilidade).Should().Equals($"{_mago.Nome} aprendeu {habilidade}.");
        }

        [Fact(DisplayName = "Testa o LvlUp do guerreiro")]
        public void TestaLvlUpDoGuerreiro()
        {
            var vidaDoGuerreiroAntesLvlUp = _guerreiro.Vida;
            var forcaDoGuerreiroAntesLvlUp = _guerreiro.Forca;

            _guerreiro.LvlUp();

            _guerreiro.Vida.Should().Equals(vidaDoGuerreiroAntesLvlUp + 2);
            _guerreiro.Vida.Should().Equals(forcaDoGuerreiroAntesLvlUp + 3);
        }

        [Fact(DisplayName = "Testa o LvlUp do mago")]
        public void TestaLvlUpDoMago()
        {
            var manaDoMagoAntesLvlUp = _mago.Mana;
            var inteligenciaDoMagoAntesLvlUp = _mago.Inteligencia;

            _guerreiro.LvlUp();

            _guerreiro.Vida.Should().Equals(manaDoMagoAntesLvlUp + 2);
            _guerreiro.Vida.Should().Equals(inteligenciaDoMagoAntesLvlUp + 3);
        }
    }
}