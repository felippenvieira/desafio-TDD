using System;
using exercicio_dois.interfaces;

namespace exercicio_dois.classes
{
    public class Livro : Produto, IImposto
    {
        public string Autor { get; set; }
        public string Tema { get; set; }
        public int QtdPag { get; set; }

        public Livro()
        {
        }

        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag) : base(nome, preco, qtd)
        {
            Autor = autor;
            Tema = tema;
            QtdPag = qtdPag;

            var imposto = CalculaImposto();
            Console.WriteLine($"R$ {imposto} de impostos sobre o livro {nome}.");
        }

        public double CalculaImposto()
        {
            if (Tema == "educativo")
            {
                Console.WriteLine($"Livro educativo não tem imposto: {Nome}.");
                return 0;
            }

            return Preco * 0.10;
        }

        public override string ToString()
        {
            return $"Título: {Nome}, preço: {Preco}, quantidade: {Qtd} em estoque.";
        }
    }
}