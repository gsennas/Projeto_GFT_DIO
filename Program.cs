using GFT_Projeto.src.Entities.Enum;
using GFT_Projeto.src.Entities.Model;
using GFT_Projeto.src.Entities.Models;

namespace GFT_PROJETO
{
    class Program{
        public static void Main(string[] args)
        {
           
            Guerreiro glaucio = new Guerreiro("Arus", 70, ClassePersonagem.Guerreiro, 5000);
            System.Console.WriteLine(glaucio);
            Mago arthur = new Mago("Gyban", 80, ClassePersonagem.Mago, 3000);
            System.Console.WriteLine(arthur);
            System.Console.WriteLine(glaucio.Ataque());  
            System.Console.WriteLine(arthur.Ataque(1)); 
            System.Console.WriteLine(arthur.Ataque(10)); 
            


        }
    }
}