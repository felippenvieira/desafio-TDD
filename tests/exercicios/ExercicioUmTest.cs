using exercicio_um.classes;
using Xunit;
using Xunit.Abstractions;
using FluentAssertions;

namespace exercicios
{
    public class ExercicioUmTest
    {
        private readonly ITestOutputHelper _output;
        private Vehicle _vehicle;

        public ExercicioUmTest(ITestOutputHelper output)
        {
            _output = output;
            _vehicle = new Vehicle();
        }

        [Fact(DisplayName = "Acelerar o veículo")]
        [Trait("Exercício Um", "Acelerar")]
        public void AccelerateVehicle()
        {
            _vehicle.Acelerar().Should().Contain("Você acelerou o veículo");
        }

        [Theory(DisplayName = "Abastecer com mais de 30 lts o veículo")]
        [InlineData(40)]
        [InlineData(50)]
        [InlineData(60)]
        public void ToFuelVehicleWithMoreThan30Liters(int value)
        {
            _vehicle.Abastecer(value).Should().Equals("O seu veículo estava com 60 litros de combustível, por isso abastecemos apenas 30");
        }

        [Theory(DisplayName = "Abastecer com menos de 30 lts o veículo")]
        [InlineData(10)]
        [InlineData(20)]
        public void ToFuelVehicleWithLessThan30Liters(int value)
        {
            _vehicle.Abastecer(value).Should().Equals("O seu veículo foi abastecido");
        }

        [Theory(DisplayName = "Abastecer o veículo com o tanque cheio")]
        [InlineData(10)]
        [InlineData(30)]
        [InlineData(60)]
        public void ToFuelVehicleWithFullTank(int value)
        {
            _vehicle.Abastecer(value).Should().Equals("Desculpe, mas o seu tanque está cheio.");
        }

        [Fact(DisplayName = "Frear carro parado")]
        public void BrakeStoppedCar()
        {
            _vehicle.Frear().Should().Equals("O veículo está parado. Não é possível frear.");
        }

        [Fact(DisplayName = "Frear carro em movimento")]
        public void BrakeMovingCar()
        {
            _vehicle.Acelerar();
            _vehicle.Frear().Should().Contain("Você freou o veículo");
        }

        [Theory(DisplayName = "Pintar o carro")]
        [InlineData("branca")]
        [InlineData("preta")]
        [InlineData("cinza")]
        public void PaintVehicle(string value)
        {
            _vehicle.Pintar(value).Should().Equals($"O seu veículo agora está com a cor {value}");
        }

        [Fact(DisplayName = "Testar se o veículo está ligado")]
        public void CheckVehicleIsOn()
        {
            _vehicle.isLigado.Should().Equals(true);
        }


        [Fact(DisplayName = "Testar se o veículo está desligado")]
        public void CheckVehicleIsOff()
        {
            _vehicle.isLigado!.Should().Equals(false);
        }

        [Fact(DisplayName = "Ligar o veículo ligado")]
        public void StartVehicleStarted()
        {
            _vehicle.Ligar().Should().Equals("Seu veículo já está ligado.");
        }

        [Fact(DisplayName = "Ligar o veículo desligado")]
        public void StartVehicle()
        {
            _vehicle.Desligar();
            _vehicle.Ligar().Should().Equals("Você ligou o veículo");
        }

        [Fact(DisplayName = "Desligar veículo desligado")]
        public void TurnOffVehicleTurnedOff()
        {
            _vehicle.Desligar();
            _vehicle.Desligar().Should().Equals("Seu veículo já está desligado");
        }

        [Fact(DisplayName = "Desligar veículo em movimento")]
        public void TurnOffMovingVehicle()
        {
            _vehicle.Acelerar();
            _vehicle.Acelerar().Should().Equals("Não é possível desligar seu veículo enquanto ele está em movimento");
        }

        [Fact(DisplayName = "Desligar veículo")]
        public void TurnOffVehicle()
        {
            // arrange
            var vehicle = new Vehicle();
            var ex = "Você desligou o veículo";

            // act
            var result = vehicle.Desligar();

            // arrange
            Assert.Equal(ex, result);

            _vehicle.Desligar().Should().Equals("Você desligou o veículo");
        }
    }
}