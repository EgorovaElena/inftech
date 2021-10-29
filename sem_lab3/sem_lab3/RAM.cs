using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem_lab3
{
    enum RamType
    {
        DDR,
        DDR2,
        DDR3,
        DDR4
    }
    class RAM : MemoryStorage
    {
        private  RamType ramType;

        public RAM(int volume_gb, int speed, RamType ramType)
           :base(volume_gb, speed)
        {
            this.ramType = ramType;
            
        }

    }
}
