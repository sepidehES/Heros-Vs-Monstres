using Heroes_Vs_Monsters.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_Vs_Monsters.Modeles
{
    public abstract class Personnages
    {
        public Personnages()
        {
            Endurance = Dice.Lancer();
            Force = Dice.Lancer(); 
            PointsDeVie = Endurance + CalculeVie.Modificateur(Endurance);
        }
        public int Endurance { get; set; }
        public int Force { get; set; }
        public int PointsDeVie { get; set; }

        public int Frapper(int degat = 0, int Force = 0)
        {
            return 0;
        }

    }
}
