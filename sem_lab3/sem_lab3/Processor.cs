using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem_lab3
{
    class Processor
    {
        private int numbersOfCores;
        private int speed;
        private string nameProcessor;
        public Processor(int numbersOfCores, int speed, string nameProcessor )
        {
            this.numbersOfCores = numbersOfCores;
            this.speed = speed;
            this.nameProcessor = nameProcessor;
          
        }
    }
}
