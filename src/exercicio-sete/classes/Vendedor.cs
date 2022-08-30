namespace exercicio_sete.classes
{
    public class Vendedor : Funcionario
    {
        public override double Bonificacao()
        {
            return Salario + 3000.00;
        }
        public Vendedor()
        {
        }

        public Vendedor(string nome, int idade, double salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }
    }
}