using System;

namespace exercicio_bonus.screens
{
    public class JogarNovamenteScreen
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Caso deseje testar outro número, digite 1.");
            Console.WriteLine("Caso deseje voltar ao menu anterior, digite 0.");
            Console.Write("Selecione a opção: ");
            var opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    EscolhaDoUsuarioScreen.Show();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Por favor, escolha um número.");
                    Console.ReadKey();
                    EscolhaDoUsuarioScreen.Show();
                    break;
            }
        }
    }
}