using exercicio_bonus.classes;
using Xunit;
using Xunit.Abstractions;
using FluentAssertions;

namespace exercicios
{
    public class ExercicioBonusTest
    {
        private FizzBuzz _fizzBuzz = new FizzBuzz();

        [Theory(DisplayName = "Testa se o número é Fizz")]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void NumeroFizz(int number)
        {
            _fizzBuzz.FizzBuzzer(number).Should().Equals("Fizz");
        }

        [Theory(DisplayName = "Testa se o número é Buzz")]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(25)]
        public void NumeroBuzz(int number)
        {
            _fizzBuzz.FizzBuzzer(number).Should().Equals("Buzz");
        }

        [Theory(DisplayName = "Testa se o número é FizzBuzz")]
        [InlineData(5)]
        [InlineData(30)]
        [InlineData(60)]
        [InlineData(75)]
        public void NumeroFizzBuzz(int number)
        {
            _fizzBuzz.FizzBuzzer(number).Should().Equals("FizzBuzz");
        }
    }
}