using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes_Vs_Monsters.Tools
{
    public class CalculeVie
    {
        public CalculeVie() 
        { 
        }
        public static int Modificateur(int endurance, int pointVie = 0)
        {
            if (endurance < 5) 
            {
                return pointVie - 1;
            }
            else if (endurance < 10)
            {
                return pointVie ;
            }
            else if (endurance < 15)
            {
                return pointVie +1;
            }
            else
            {
                return pointVie + 2;
            }
            return 0;
        }
    }
}
