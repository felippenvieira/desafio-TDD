namespace exercicio_sete.classes
{
    public class Supervisor : Funcionario
    {
        public override double Bonificacao()
        {
            return Salario + 5000.00;
        }

        public Supervisor()
        {
        }

        public Supervisor(string nome, int idade, double salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }
    }
}