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

namespace sem5_lab4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Party party;
        PartyWithHistory partyWithHistory;
        public MainWindow()
        {

            InitializeComponent();
            buttonCalculate.Click += CreateParty;
            buttonLastYear.Click += CreatePartyWithHistory;
        }
        public void CreateParty(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = inputName.Text;
                int memberCount = Int32.Parse(inputMemberCount.Text);
                double votesPersent = Convert.ToDouble(inputVotesPersent.Text.Replace('.', ','));
                party = new Party(name, memberCount, votesPersent);
                OutputInformation(party);
            }
            catch (Exception ex)
            {
                outputInformation.Text = "Введите корректные данные";
            }
        }
        public void CreatePartyWithHistory(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = inputName.Text;
                int memberCount = Int32.Parse(inputMemberCount.Text);
                double votesPersent = Convert.ToDouble(inputVotesPersent.Text.Replace('.', ','));
                int numberPartyLastYear = Int32.Parse(inputNumberPartyLastYear.Text);
                party = new PartyWithHistory (name, memberCount, votesPersent, numberPartyLastYear);
                OutputInformation(party);
            }
            catch (Exception exc)
            {
                outputInformation.Text = "Введите корректные данные";
            }
        }

        public void OutputInformation(Party party)
        {
            outputInformation.Text = "название партии: " + party.Name + "\n" +
                                     "качество партии: " + party.Quality().ToString();

        }
    }
}
