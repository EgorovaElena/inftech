using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem_lab3
{
    class VideoCard
    {
        private int volume_gb =4;
        private int speed;
        private string nameVideoCard;
        private bool isDiscret;

        public VideoCard(int volume_gb, int speed, string nameVideoCard)
        {
            this.volume_gb = volume_gb;
            this.speed = speed;
            this.nameVideoCard = nameVideoCard;

        }
    }
}
