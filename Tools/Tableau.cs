using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_Vs_Monsters.Tools
{
    public class Tableau
    {
        public void AfficheTableau(List<int> tab) 
        {
            for (int i = 0 ; i < tab.Count; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }
    }
}
