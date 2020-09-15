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
using System.Windows.Shapes;

namespace Kursovay1kurs
{
    /// <summary>
    /// Логика взаимодействия для PetriNet.xaml
    /// </summary>
    public partial class PetriNet : Window
    {
        
        public PetriNet()
        {
            InitializeComponent();

            ListOfConditions.Items.Add("S0(S0 S1 S2 S3)");
            ListOfConditions.Items.Add("S1(S0 S1 S2 S3)");
            ListOfConditions.Items.Add("S2(S0 S1 S2 S3)");
            ListOfConditions.Items.Add("S3(S0 S1 S2 S3)");
            CurrentCondition.Text = "S0";
            
        }

        private void Transition(object sender, RoutedEventArgs e)
        {
            switch(ListOfConditions.SelectedIndex)
            {
                case 0:
                    CurrentCondition.Text = "S0";
                    break;
                case 1:
                    CurrentCondition.Text = "S1";
                    break;
                case 2:
                    CurrentCondition.Text = "S2";
                    break;
                case 3:
                    CurrentCondition.Text = "S3";
                    break;
            }
        }

    private void GoToFinStMachine(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            this.Close();
        }

    }
}
