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
        Position currentPos = new Position();
        private void Transition(object sender, RoutedEventArgs e)
        {
            switch(ListOfConditions.SelectedIndex)
            {
                case 0:
                    if(currentPos.T0())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied";
                    break;
                case 1:
                    currentPos.T1();
                    break;
                case 2:
                    currentPos.T2();
                    break;
                case 3:
                    currentPos.T3();
                    break;
                case 4:
                    currentPos.T4();
                    break;
                case 5:
                    currentPos.T5();
                    break;
                case 6:
                    currentPos.T6();
                    break;
                case 7:
                    currentPos.T7();
                    break;
                case 8:
                    currentPos.T8();
                    break;
                case 9:
                    currentPos.T9();
                    break;
                case 10:
                    currentPos.T10();
                    break;
                case 11:
                    currentPos.T11();
                    break;
                case 12:
                    currentPos.T12();
                    break;
                case 13:
                    currentPos.T13();
                    break;
                case 14:
                    currentPos.T14();
                    break;
                case 15:
                    currentPos.T15();
                    break;
                case 16:
                    currentPos.T16();
                    break;
                case 17:
                    currentPos.T17();
                    break;
                case 18:
                    currentPos.T18();
                    break;
                case 19:
                    currentPos.T19();
                    break;
                case 20:
                    currentPos.T20();
                    break;
                case 21:
                    currentPos.T21();
                    break;
                case 22:
                    currentPos.T22();
                    break;
                case 23:
                    currentPos.T23();
                    break;
                case 24:
                    currentPos.T24();
                    break;
                case 25:
                    currentPos.T25();
                    break;
                case 26:
                    currentPos.T26();
                    break;
                case 27:
                    currentPos.T27();
                    break;
                case 28:
                    currentPos.T28();
                    break;
                case 29:
                    currentPos.T29();
                    break;
                case 30:
                    currentPos.T30();
                    break;
                case 31:
                    currentPos.T31();
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
