using System;
using System.Collections.Generic;

namespace exercicio_tres.classes
{
    public class Mago : Personagem
    {
        public List<string> Magia { get; set; }

        public override void LvlUp()
        {
            Mana += 2;
            Inteligencia += 3;
        }

        public Mago()
        {

        }

        public Mago(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
            Magia = new List<string>();
            Nome = nome;
            Vida = vida;
            Mana = mana;
            Inteligencia = inteligencia;
            Forca = forca;
            Level = level;
        }

        public string Attack()
        {
            Random rd = new Random();
            var numeroRandomico = rd.Next(0, 300);
            var attack = (Inteligencia * Level) + numeroRandomico;
            return $"O ataque de {Nome} foi de: {attack} pts.";
        }

        public string AprenderMagia(string magia)
        {
            Magia.Add(magia);
            return $"{Nome} aprendeu {magia}.";
        }
    }
}