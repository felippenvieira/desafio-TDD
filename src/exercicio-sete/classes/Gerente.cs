namespace exercicio_sete.classes
{
    public class Gerente : Funcionario
    {
        public override double Bonificacao()
        {
            return Salario + 10000.00;
        }

        public Gerente()
        {
        }

        public Gerente(string nome, int idade, double salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }
    }
}