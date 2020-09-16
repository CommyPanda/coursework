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


//added some text from console
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

            ListOfConditions.Items.Add("t0");
            ListOfConditions.Items.Add("t1");
            ListOfConditions.Items.Add("t2");
            ListOfConditions.Items.Add("t3");
            ListOfConditions.Items.Add("t4");
            ListOfConditions.Items.Add("t5");
            ListOfConditions.Items.Add("t6");
            ListOfConditions.Items.Add("t7");
            ListOfConditions.Items.Add("t8");
            ListOfConditions.Items.Add("t9");
            ListOfConditions.Items.Add("t10");
            ListOfConditions.Items.Add("t11");
            ListOfConditions.Items.Add("t12");
            ListOfConditions.Items.Add("t13");
            ListOfConditions.Items.Add("t14");
            ListOfConditions.Items.Add("t15");
            ListOfConditions.Items.Add("t16");
            ListOfConditions.Items.Add("t17");
            ListOfConditions.Items.Add("t18");
            ListOfConditions.Items.Add("t19");
            ListOfConditions.Items.Add("t20");
            ListOfConditions.Items.Add("t21");
            ListOfConditions.Items.Add("t22");
            ListOfConditions.Items.Add("t23");
            ListOfConditions.Items.Add("t24");
            ListOfConditions.Items.Add("t25");
            ListOfConditions.Items.Add("t26");
            ListOfConditions.Items.Add("t27");
            ListOfConditions.Items.Add("t28");
            ListOfConditions.Items.Add("t29");
            ListOfConditions.Items.Add("t30");
            ListOfConditions.Items.Add("t31");
            CurrentCondition.Text = "S0";

        }
        /*
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
        */
        private void Transition(object sender, RoutedEventArgs e)
        {
            switch(ListOfConditions.SelectedIndex)
            {
                case 0:
                    CurrentCondition.Text = "working!";
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                case 22:
                    break;
                case 23:
                    break;
                case 24:
                    break;
                case 25:
                    break;
                case 26:
                    break;
                case 27:
                    break;
                case 28:
                    break;
                case 29:
                    break;
                case 30:
                    break;
                case 31:
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
