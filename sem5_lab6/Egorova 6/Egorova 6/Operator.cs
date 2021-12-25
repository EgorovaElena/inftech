using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egorova_6
{
    class Operator
    {
        public bool controllerIsOn { get; set; }
        public Operator(){ }

        public void onController()
        {
            controllerIsOn = true;
        }

        public void offController()
        {
            controllerIsOn = false;
        }
    }
}
