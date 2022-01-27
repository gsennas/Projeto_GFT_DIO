
using GFT_Projeto.src.Entities.Enum;

namespace GFT_Projeto.src.Entities.Models
{
    public abstract class  Personagem
    {
        public string Nome { get; set; }
        public int Lvl { get; set; }
        public ClassePersonagem Classe { get; set; }
        public int HP { get; set; }

        public Personagem(string nome, int lvl, ClassePersonagem classe, int hP)
        {
            Nome = nome;
            Lvl = lvl;
            Classe = classe;
            HP = hP;
        }

        public Personagem()
        {
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "Nome: " + Nome + " Lvl:" + Lvl + " Classe: " + Classe + " Hp:" + HP;
        }
        public virtual string Ataque()
        {
            return "";
        }

    }
}