using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_prov_del_2
{
    class Car
    {
        public int passangers;
        public int contrabandAmount;
        public bool alreadyChecked;
        public static Random generator = new Random();

        public bool Examine()
        {
            alreadyChecked = true;
            int chanceToFind;
            chanceToFind = generator.Next(1, 101);
            

            if (contrabandAmount > 0) //om bilen innehåller contraband, undersök
            {
                if (contrabandAmount == 1 && chanceToFind < 10) //låg chans att 1 contraband hittas
                {
                    return true;
                }
                if (contrabandAmount == 2 && chanceToFind < 25)
                {
                    return true;
                }
                if (contrabandAmount == 3 && chanceToFind < 50)
                {
                    return true;
                }
                if (contrabandAmount == 4 && chanceToFind < 75)
                {
                    return true;
                }
                else return false;
            }

            else return false;
        }
    }
}
