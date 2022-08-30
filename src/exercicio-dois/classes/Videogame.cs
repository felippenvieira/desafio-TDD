using exercicio_dois.interfaces;

namespace exercicio_dois.classes
{
    public class VideoGame : Produto, IImposto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool IsUsado { get; set; }

        public VideoGame()
        {
        }

        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado) : base(nome, preco, qtd)
        {
            Marca = marca;
            Modelo = modelo;
            IsUsado = isUsado;
        }

        public double CalculaImposto()
        {
            if (IsUsado) return Preco * 0.25;

            return Preco * 0.45;
        }

        public override string ToString()
        {
            return $"Vídeo-game: {Nome}, preço: {Preco}, quantidade: {Qtd} em estoque.";
        }
    }
}