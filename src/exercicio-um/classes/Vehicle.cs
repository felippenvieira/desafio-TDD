using System;

namespace exercicio_um.classes
{
    public class Vehicle
    {
        public string Marca { get; set; }
        public string Model { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public float Km { get; set; }
        public bool isLigado { get; set; }
        public int litrosCombustivel { get; set; }
        public int Velocidade { get; set; }
        public double Preco { get; set; }

        public Vehicle()
        {
            Cor = "cinza";
            isLigado = true;
            litrosCombustivel = 30;
            Velocidade = 0;
        }

        public string Acelerar()
        {
            if (litrosCombustivel <= 0) return "Desculpe, mas você está com o tanque vazio.";

            if (isLigado == false) return "Primeiro você precisa ligar o veículo.";

            Velocidade += 20;
            litrosCombustivel -= 5;

            return $"Você acelerou o veículo e agora está na velocidade {Velocidade}.";
        }

        public string Abastecer(int quantidade)
        {
            Console.WriteLine();
            if (litrosCombustivel >= 60) return "Desculpe, mas o seu tanque está cheio.";

            if ((litrosCombustivel + quantidade) > 60)
            {
                int quantidadeAtual = litrosCombustivel;
                int quantidadeAbastecida = 60 - quantidadeAtual;
                litrosCombustivel += quantidadeAbastecida;
                return $"O seu veículo estava com {quantidadeAtual} litros de combustível, por isso abastecemos apenas {quantidadeAbastecida}";
            }

            litrosCombustivel += quantidade;

            return "O seu veículo foi abastecido.";
        }

        public string Frear()
        {
            if (Velocidade == 0) return "O veículo está parado. Não é possível frear.";

            Velocidade -= 20;

            return $"Você freou o veículo e agora está andando na velocidade {Velocidade}.";
        }

        public string Pintar(string cor)
        {
            Cor = cor;

            return $"O seu veículo agora está com a cor {Cor}.";
        }

        public string Ligar()
        {
            if (isLigado == true) return "Seu veículo já está ligado.";

            isLigado = true;

            return "Você ligou o veículo";
        }

        public string Desligar()
        {
            if (isLigado == false) return "Seu veículo já está desligado.";

            if (Velocidade > 0) return "Não é possível desligar seu veículo enquanto ele está em movimento.";

            isLigado = false;

            return "Você desligou o veículo";
        }
    }
}