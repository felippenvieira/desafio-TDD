using System;
using exercicio_sete.classes;

namespace exercicio_sete.screens
{
    public class ExercicioSeteMainScreen
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("-------------------Exercício sete-----------------------");
            var gerente = new Gerente("Matheus", 32, 17000.00);
            var supervisor = new Supervisor("Lucas", 38, 10000.00);
            var vendedor = new Vendedor("Felippe", 27, 6000.00);

            Console.WriteLine($"O gerente {gerente.Nome}, que tem {gerente.Idade} anos, percebendo o salário de {gerente.Salario}, recebeu uma bonificação de {gerente.Bonificacao()}.");
            Console.WriteLine($"O supervisor {supervisor.Nome}, que tem {supervisor.Idade} anos, percebendo o salário de {supervisor.Salario}, recebeu uma bonificação de {supervisor.Bonificacao()}.");
            Console.WriteLine($"O vendedor {vendedor.Nome}, que tem {vendedor.Idade} anos, percebendo o salário de {vendedor.Salario}, recebeu uma bonificação de {vendedor.Bonificacao()}.");

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}