namespace exercicio_tres.classes
{
    public abstract class Personagem
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Mana { get; set; }
        public float Xp { get; set; }
        public int Inteligencia { get; set; }
        public int Forca { get; set; }
        public int Level { get; set; }

        public Personagem()
        {
        }

        public Personagem(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level)
        {
            Nome = nome;
            Vida = vida;
            Mana = mana;
            Xp = xp;
            Inteligencia = inteligencia;
            Forca = forca;
            Level = level;
        }

        public virtual void LvlUp()
        {
            Vida += 1;
            Mana += 1;
            Inteligencia += 1;
            Forca += 1;
        }
    }
}