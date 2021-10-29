using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem_lab3
{
    class MemoryStorage
    {
        private int volume_gb;
        private int speed;
        public int VolumeGb
        {
            get { return volume_gb; }
            set { volume_gb = value; }
        }

        public int Speed
        {
            get { return speed; }
            set {speed = value; }
        }

        public MemoryStorage(int volume_gb, int speed)
        {
            this.volume_gb = volume_gb;
            this.speed = speed;

        }

    }
}
