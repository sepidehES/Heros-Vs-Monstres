using System;
using System.Collections.Generic;
using System.Linq;
using Heroes_Vs_Monsters.Modeles;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Heroes_Vs_Monsters.Tools
{
    public enum DiceType
    {
        D4 = 4,
        D6 = 6,
    }
    public class Dice
    {
        private static int plusPetitNombre, result;

        public static int Lancer(DiceType dice = DiceType.D6, int nombre = 4)
        {
            List<int> DiceList = new List<int>();
            Random rnd = new Random();

            int diceValue = (int)dice;

            for (int i = 0; i < nombre; i++)
                DiceList.Add(rnd.Next(1, diceValue));

            for (int i = 0; i < DiceList.Count; i++)
            {
                if (i == 0)
                    plusPetitNombre = DiceList[i];

                else if (DiceList[i] < plusPetitNombre)
                    plusPetitNombre = DiceList[i];

            }
            for (int i = 0; i < DiceList.Count; i++)
            {
                if (DiceList[i] == plusPetitNombre)
                {
                    DiceList.Remove(DiceList[i]);
                    break;
                }
            }
            result = 0;
            for (int i = 0; i < DiceList.Count; i++)
            {
                result += DiceList[i];
            }

            return result;
        }
    }
}



