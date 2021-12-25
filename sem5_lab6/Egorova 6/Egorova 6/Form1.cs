using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egorova_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void forward_Click(object sender, EventArgs e)
        {
            Globals.quadcopter.moveForward();
            show_quadrocopter_coordinats();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Globals.quadcopter.moveBack();
            show_quadrocopter_coordinats();
        }

        private void keft_Click(object sender, EventArgs e)
        {
            Globals.quadcopter.moveLeft();
            show_quadrocopter_coordinats();
        }

        private void right_Click(object sender, EventArgs e)
        {
            Globals.quadcopter.moveRight();
            show_quadrocopter_coordinats();
        }

        private void up_Click(object sender, EventArgs e)
        {
            Globals.quadcopter.moveUp();
            show_quadrocopter_coordinats();
        }

        private void down_Click(object sender, EventArgs e)
        {
            Globals.quadcopter.moveDown();
            show_quadrocopter_coordinats();
        }

        private void Controller_on_Click(object sender, EventArgs e)
        {
            Globals.Operator.onController();
            show_quadrocopter_status();
        }
        private void controller_off_Click(object sender, EventArgs e)
        {
            Globals.Operator.offController();
            Globals.quadcopter.OffQuadcopter();
            show_quadrocopter_status();
        }
        private void dron_on_Click(object sender, EventArgs e)
        {
            if (Globals.Operator.controllerIsOn == false)
            {
                label1.Text = "Сообщение Перед включением дрона, включите пульт";
            }
            else
            {
                label1.Text = "Сообщение";
                Globals.quadcopter.OnQuadcopter();
                show_quadrocopter_status();
                show_quadrocopter_coordinats();
            }
        }
        private void dron_off_Click(object sender, EventArgs e)
        {
            if (Globals.Operator.controllerIsOn == false)
            {
                label1.Text = "Сообщение Перед выключением дрона, включите пульт";
            }
            else
            {
                label1.Text = "Сообщение";
                Globals.quadcopter.OffQuadcopter();
                show_quadrocopter_status();
            }
        }
        private void show_quadrocopter_status()
        {
            power.Checked = Globals.quadcopter.isOn;
            GPS.Checked = Globals.quadcopter.GPSisActive;
            checkBox1.Checked = Globals.Operator.controllerIsOn;
        }

        private void show_quadrocopter_coordinats()
        {
            Koords.Text = "Координаты: x:" + Globals.quadcopter.x + "y:" + Globals.quadcopter.y + "z:" + Globals.quadcopter.z;
        }

        private void call_operator_Click(object sender, EventArgs e)
        {
            Mechanic mechanic = new Mechanic();
            mechanic.Repair_quadcopter(Globals.quadcopter);
            show_quadrocopter_status();
        }
    }
}
