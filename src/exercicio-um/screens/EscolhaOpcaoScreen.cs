using System;
using exercicio_um.classes;

namespace exercicio_um.screens
{
    public class EscolhaOpcaoScreen
    {
        public static void Show(Vehicle vehicle)
        {
            try
            {
                Console.Write("Escolha uma opção: ");
                var option = short.Parse(Console.ReadLine());

                while (option != 0)
                {
                    switch (option)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine(vehicle.Acelerar());
                            MenuScreen.Show(vehicle);
                            Console.Write("Escolha outra opção: ");
                            option = short.Parse(Console.ReadLine());
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine();
                            Console.Write("Quantos litros você deseja abastecer? ");
                            var liters = int.Parse(Console.ReadLine());
                            Console.WriteLine(vehicle.Abastecer(liters));
                            Console.WriteLine();
                            MenuScreen.Show(vehicle);
                            Console.Write("Escolha outra opção: ");
                            option = short.Parse(Console.ReadLine());
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine(vehicle.Frear());
                            Console.WriteLine();
                            MenuScreen.Show(vehicle);
                            Console.Write("Escolha outra opção: ");
                            option = short.Parse(Console.ReadLine());
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine();
                            Console.Write("Qual cor você deseja pintar o veículo? ");
                            var color = Console.ReadLine();
                            Console.WriteLine(vehicle.Pintar(color));
                            Console.WriteLine();
                            MenuScreen.Show(vehicle);
                            Console.Write("Escolha outra opção: ");
                            option = short.Parse(Console.ReadLine());
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine(vehicle.Ligar());
                            Console.WriteLine();
                            MenuScreen.Show(vehicle);
                            Console.Write("Escolha outra opção: ");
                            option = short.Parse(Console.ReadLine());
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine(vehicle.Desligar());
                            Console.WriteLine();
                            MenuScreen.Show(vehicle);
                            Console.Write("Escolha outra opção: ");
                            option = short.Parse(Console.ReadLine());
                            break;
                        case 0:
                            break;
                        default:
                            Console.Clear();
                            MenuScreen.Show(vehicle);
                            Console.Write("Escolha uma opção válida: ");
                            option = short.Parse(Console.ReadLine());
                            break;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Desculpe, mas sua opção foi inválida.");
                Show(vehicle);
            }
        }
    }
}