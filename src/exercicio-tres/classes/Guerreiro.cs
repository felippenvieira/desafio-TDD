using System;
using System.Collections.Generic;

namespace exercicio_tres.classes
{
    public class Guerreiro : Personagem
    {
        public List<string> Habilidade { get; set; }
        public override void LvlUp()
        {
            Vida += 2;
            Forca += 3;
        }

        public Guerreiro()
        {

        }

        public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
            Habilidade = new List<string>();
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
            var attack = (Forca * Level) + numeroRandomico;
            return $"O ataque de {Nome} foi de: {attack} pts.";
        }

        public string AprenderHabilidade(string habilidade)
        {
            Habilidade.Add(habilidade);
            return $"{Nome} aprendeu {habilidade}.";
        }
    }
}