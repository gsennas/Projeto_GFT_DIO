using GFT_Projeto.src.Entities.Enum;
using GFT_Projeto.src.Entities.Models;

namespace GFT_Projeto.src.Entities.Model
{
    public class Mago : Personagem
    {
        public Mago(string nome, int lvl, ClassePersonagem classe, int hP) : base(nome, lvl, classe, hP)
        {
        }

        public override string Ataque()
        {
            return this.Nome + " Atacou com magia";
        }
        public string Ataque(int bonus)
        {
            if (bonus > 6)
            {
                return this.Nome + " Lançou super magia com bomus de: " + bonus + " de Ataque";
            }
            else
            {
                return this.Nome + " Lançou uma magia fraca com bonus de: " + bonus + " Ataque";
            }

        }

    }
}