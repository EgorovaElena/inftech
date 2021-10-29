using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sem_lab3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Computer computer;
        public MainWindow()
        {
            HardDrive hardDrive = new HardDrive(512, 20, ConnectionTypeEnum.SATA);
            RAM rAM = new RAM(2, 2666, RamType.DDR4);
            Processor processor = new Processor(4, 2666, "Intel Xeon Platinum 8380");
            VideoCard videoCard = new VideoCard(5, 266, "Intel Iris Plus Graphics 940");
            computer = new Computer(hardDrive, rAM, processor, videoCard);
            InitializeComponent();
            showHardDriveButton.Click += HandleShowHardDrive;
            checkVirusButton.Click += HandleCheckVirus;
            turnOnOffButton.Click += HandleTurnOnOff;

        }
        public void HandleShowHardDrive(object sender, RoutedEventArgs e)
        {
            windowTextBox.Text = computer.HardDriveSize().ToString() + " Gb";
        }
        public void HandleCheckVirus(object sender, RoutedEventArgs e)
        {
            if (computer.CheckingForViruses())
            {
                windowTextBox.Text = "имеется вирус";
            }
            else
            {
                windowTextBox.Text = "не имеется вирусов";
            }


        }
        public void HandleTurnOnOff(object sender, RoutedEventArgs e)
        {
            if (computer.IsOn)
            {
                computer.TurnOff();
                windowTextBox.Text = "Компьютер выключен ";

            }
            else
            {
                computer.TurnOn();
                windowTextBox.Text = "компютер включён";
            }

        }
    }
}
