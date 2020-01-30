using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_prov_del_2
{
    class CleanCar : Car
    {
        public CleanCar()
        {
            passangers = generator.Next(1,4); //slump mellan 1 - 3, taket är inte inkluderande i en random!
            contrabandAmount = 0;
        }
    }
}
