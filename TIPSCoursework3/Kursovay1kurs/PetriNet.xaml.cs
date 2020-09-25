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
            CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";

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
                    if (currentPos.T1())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied";
                    break;
                case 2:
                    if (currentPos.T2())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied";
                    break;
                case 3:
                    if (currentPos.T3())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied"; break;
                case 4:
                    if (currentPos.T4())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied";
                    break;
                case 5:
                    if (currentPos.T5())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied";
                    break;
                case 6:
                    if (currentPos.T6())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied";
                    break;
                case 7:
                    if (currentPos.T7())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied";
                    break;
                case 8:
                    if (currentPos.T8())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied";
                    break;
                case 9:
                    if (currentPos.T9())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied";
                    break;
                case 10:
                    if (currentPos.T10())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied";
                    break;
                case 11:
                    if (currentPos.T11())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied";
                    break;
                case 12:
                    if (currentPos.T12())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied";
                    break;
                case 13:
                    if (currentPos.T13())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied";
                    break;
                case 14:
                    if (currentPos.T14())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied";
                    break;
                case 15:
                    if (currentPos.T15())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied";
                    break;
                case 16:
                    if (currentPos.T16())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied"; break;
                case 17:
                    if (currentPos.T17())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied"; break;
                case 18:
                    if (currentPos.T18())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied"; break;
                case 19:
                    if (currentPos.T19())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied"; break;
                case 20:
                    if (currentPos.T20())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied"; break;
                case 21:
                    if (currentPos.T21())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied"; break;
                case 22:
                    if (currentPos.T22())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied"; break;
                case 23:
                    if (currentPos.T23())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied"; break;
                case 24:
                    if (currentPos.T24())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied"; break;
                case 25:
                    if (currentPos.T25())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied"; break;
                case 26:
                    if (currentPos.T26())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied"; break;
                case 27:
                    if (currentPos.T27())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied"; break;
                case 28:
                    if (currentPos.T28())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied"; break;
                case 29:
                    if (currentPos.T29())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied"; break;
                case 30:
                    if (currentPos.T30())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied";
                    break;
                case 31:
                    if (currentPos.T31())
                        CurrentCondition.Text = $"x0({currentPos.Getx0()}), x1({currentPos.Getx1()}), x2({currentPos.Getx2()}), x3({currentPos.Getx3()}), x4({currentPos.Getx4()}), x5({currentPos.Getx5()}), x6({currentPos.Getx6()}), x7({currentPos.Getx7()})\n" +
                            $"S0({currentPos.GetS0()}), S1({currentPos.GetS1()}), S2({currentPos.GetS2()}), S3({currentPos.GetS3()})\n" +
                            $"y0({currentPos.Gety0()}), y1({currentPos.Gety1()})";
                    else
                        CurrentCondition.Text = "Error: transition is denied";
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
