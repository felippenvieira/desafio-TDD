using exercicio_sete.classes;
using Xunit;
using FluentAssertions;

namespace exercicios
{
    public class ExercicioSeteTest
    {
        private Gerente _gerente = new Gerente("Teste", 21, 1000);
        private Supervisor _supervisor = new Supervisor("Teste", 21, 1000);
        private Vendedor _vendedor = new Vendedor("Teste", 21, 1000);

        [Fact(DisplayName = "Testa se todos os campos do gerente estão preenchidos")]
        public void TodosOsCamposDoGerenteEstaoPreenchidos()
        {
            _gerente.Nome.Should().NotBeEmpty();
            _gerente.Idade.Should().BePositive();
            _gerente.Salario.Should().BePositive();
        }

        [Fact(DisplayName = "Testa se todos os campos do supervisor estão preenchidos")]
        public void TodosOsCamposDoSupervisorEstaoPreenchidos()
        {
            _supervisor.Nome.Should().NotBeEmpty();
            _supervisor.Idade.Should().BePositive();
            _supervisor.Salario.Should().BePositive();
        }

        [Fact(DisplayName = "Testa se todos os campos do vendedor estão preenchidos")]
        public void TodosOsCamposDoVendedorEstaoPreenchidos()
        {
            _vendedor.Nome.Should().NotBeEmpty();
            _vendedor.Idade.Should().BePositive();
            _vendedor.Salario.Should().BePositive();
        }

        [Fact(DisplayName = "Testa a bonificação do gerente")]
        public void TestaBonificacaoDoGerente()
        {
            _gerente.Bonificacao().Should().Equals(_gerente.Salario + 10000);
        }

        [Fact(DisplayName = "Testa a bonificação do supervisor")]
        public void TestaBonificacaoDoSupervisor()
        {
            _supervisor.Bonificacao().Should().Equals(_gerente.Salario + 5000);
        }

        [Fact(DisplayName = "Testa a bonificação do vendedor")]
        public void TestaBonificacaoDovendedor()
        {
            _vendedor.Bonificacao().Should().Equals(_gerente.Salario + 3000);
        }
    }
}