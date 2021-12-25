using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egorova_6
{
    class Quadcopter
    {
        public bool isOn { get; set; }
        public bool GPSisActive { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public Quadcopter()
        {
            isOn = false;
            GPSisActive = false;
            x = 0;
            y = 0;
            z = 0;
        }

        public void OnQuadcopter()
        {
            Random rnd = new Random();
            isOn = true;
            if (rnd.Next(1, 10) > 5)
            {
                GPSisActive = true;
            }
        }



        public void OffQuadcopter()
        {
            isOn = false;
            GPSisActive = false;
        }

        public void moveBack()
        {
            if (isOn == true)
            {
                x -= 1;
            }
        }
        public void moveForward()
        {
            if (isOn == true)
            {
                x += 1;
            }
        }
        public void moveDown()
        {
            if (isOn == true)
            {
                if (z - 1 > -1)
                {
                    z -= 1;
                }
            }
        }
        public void moveUp()
        {
            if (isOn == true)
            {
                z += 1;
            }
        }
        public void moveLeft()
        {
            if (isOn == true)
            {
                y -= 1;
            }
        }
        public void moveRight()
        {
            if (isOn == true)
            {
                y += 1;
            }
        }
    }
}
