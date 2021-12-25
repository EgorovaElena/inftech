using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egorova_6
{
    class Mechanic : IMechanic
    {
        public void Repair_quadcopter(Quadcopter quadcopter)
        {
            quadcopter.GPSisActive = true;
        }
    }
}
