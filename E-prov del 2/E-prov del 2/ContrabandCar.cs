using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_prov_del_2
{
    class ContrabandCar : Car
    {
        public ContrabandCar()
        {
            passangers = generator.Next(1, 5);
            contrabandAmount = generator.Next(1, 5);
        }
    }
}
