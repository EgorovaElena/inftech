using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem_lab3
{
    class Computer
    {
        private HardDrive hardDrive;
        private RAM rAM;
        private Processor processor;
        private VideoCard videoCard;
        private bool isOn = false;

        public Computer (HardDrive hardDrive, RAM rAM, Processor processor,VideoCard videoCard)
        {
            this.hardDrive = hardDrive;
            this.rAM = rAM;
            this.processor = processor;
            this.videoCard = videoCard;
        }

        public void TurnOn()
        {
            isOn = true;
        }
        public void TurnOff()
        {
            isOn = false;
        }
        public bool IsOn
        {
            get { return isOn; }
        }

        public bool CheckingForViruses()
        {
            
            Random rng = new Random();
            int randomNumber =  rng.Next(10);
            if (randomNumber % 2 == 1)
            {
                return true;
            }
            else { return false; }

        }

        public int HardDriveSize()
        {
            return hardDrive.VolumeGb;
        
        }

    }
}
