using GFT_Projeto.src.Entities.Enum;
using GFT_Projeto.src.Entities.Models;

namespace GFT_Projeto.src.Entities.Model
{
    public class Guerreiro : Personagem
    {
        public Guerreiro(string nome, int lvl, ClassePersonagem classe, int hP) : base(nome, lvl, classe, hP)
        {
        }

        public override string Ataque()
        {
            return this.Nome + " Atacou com sua espada";
        }
    }
}