namespace exercicio_sete.classes
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }

        public virtual double Bonificacao()
        {
            return Salario;
        }
    }
}