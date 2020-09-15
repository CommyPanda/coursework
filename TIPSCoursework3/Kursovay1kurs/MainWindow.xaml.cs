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

namespace Kursovay1kurs
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numOfRow = 0;

        int condition = 0;
        public MainWindow()
        {
            InitializeComponent();

            
            for (int i = 0; i < 3; i++)
            {
                ColumnDefinition column = new ColumnDefinition();
                column.Width = new GridLength(52, GridUnitType.Pixel);
                hisCon.ColumnDefinitions.Add(column);
            }

            RowDefinition row = new RowDefinition();
            hisCon.RowDefinitions.Add(row);


            TextBlock someText = new TextBlock();
                someText.Text = "S0";
                someText.FontSize = 14;
                someText.VerticalAlignment = VerticalAlignment.Center;
                someText.HorizontalAlignment = HorizontalAlignment.Center;

                Grid.SetRow(someText, 0);
                Grid.SetColumn(someText, 1);
                hisCon.Children.Add(someText);


        }

        public void HandlerCondition(int input)
        {
            TextBlock x = new TextBlock();
            x.FontSize = 14;
            x.VerticalAlignment = VerticalAlignment.Center;
            x.HorizontalAlignment = HorizontalAlignment.Center;

            TextBlock S = new TextBlock();
            S.FontSize = 14;
            S.VerticalAlignment = VerticalAlignment.Center;
            S.HorizontalAlignment = HorizontalAlignment.Center;

            TextBlock y = new TextBlock();
            y.FontSize = 14;
            y.VerticalAlignment = VerticalAlignment.Center;
            y.HorizontalAlignment = HorizontalAlignment.Center;

            RowDefinition row = new RowDefinition();
            hisCon.RowDefinitions.Add(row);

            Grid.SetColumn(x, 0);
            Grid.SetRow(x, numOfRow);

            Grid.SetColumn(S, 1);
            Grid.SetRow(S, numOfRow + 1);

            Grid.SetColumn(y, 2);
            Grid.SetRow(y, numOfRow);

            

            switch (condition)
            {
                case 0:
                    switch (input)
                    {
                        case 0:

                            x.Text = "x0";
                            S.Text = "S0";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;
                            break;
                        case 1:

                            x.Text = "x1";
                            S.Text = "S0";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;
                            break;
                        case 2:

                            x.Text = "x2";
                            S.Text = "S0";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;
                            break;
                        case 3:

                            x.Text = "x3";
                            S.Text = "S0";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;
                            break;
                        case 4:

                            x.Text = "x4";
                            S.Text = "S0";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;
                            break;
                        case 5:

                            x.Text = "x5";
                            S.Text = "S1";
                            y.Text = "y1";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 1;
                            break;
                        case 6:

                            x.Text = "x6";
                            S.Text = "S2";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 2;
                            break;
                        case 7:

                            x.Text = "x7";
                            S.Text = "S3";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 3;
                            break;
                    }
                
                    break;
                case 1:
                    switch (input)
                    {
                        case 0:

                            x.Text = "x0";
                            S.Text = "S0";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 0;
                            break;
                        case 1:

                            x.Text = "x1";
                            S.Text = "S0";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 0;
                            break;
                        case 2:

                            x.Text = "x2";
                            S.Text = "S0";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 0;
                            break;
                        case 3:

                            x.Text = "x3";
                            S.Text = "S0";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 0;
                            break;
                        case 4:

                            x.Text = "x4";
                            S.Text = "S0";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 0;
                            break;
                        case 5:

                            x.Text = "x5";
                            S.Text = "S1";
                            y.Text = "y1";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 1;
                            break;
                        case 6:

                            x.Text = "x6";
                            S.Text = "S2";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 2;
                            break;
                        case 7:

                            x.Text = "x7";
                            S.Text = "S3";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 3;
                            break;
                    }
                    break;

                case 2:
                    switch (input)
                    {
                        case 0:

                            x.Text = "x0";
                            S.Text = "S0";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 0;
                            break;
                        case 1:

                            x.Text = "x1";
                            S.Text = "S0";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 0;
                            break;
                        case 2:

                            x.Text = "x2";
                            S.Text = "S0";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 0;
                            break;
                        case 3:

                            x.Text = "x3";
                            S.Text = "S0";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 0;
                            break;
                        case 4:

                            x.Text = "x4";
                            S.Text = "S0";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 0;
                            break;
                        case 5:

                            x.Text = "x5";
                            S.Text = "S1";
                            y.Text = "y1";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 1;
                            break;
                        case 6:

                            x.Text = "x6";
                            S.Text = "S2";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 2;
                            break;
                        case 7:

                            x.Text = "x7";
                            S.Text = "S3";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 3;
                            break;
                    }
                    break;

                case 3:
                    switch (input)
                    {
                        case 0:

                            x.Text = "x0";
                            S.Text = "S0";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 0;
                            break;
                        case 1:

                            x.Text = "x1";
                            S.Text = "S0";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 0;
                            break;
                        case 2:

                            x.Text = "x2";
                            S.Text = "S0";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 0;
                            break;
                        case 3:

                            x.Text = "x3";
                            S.Text = "S0";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 0;
                            break;
                        case 4:

                            x.Text = "x4";
                            S.Text = "S0";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 0;
                            break;
                        case 5:

                            x.Text = "x5";
                            S.Text = "S1";
                            y.Text = "y1";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 1;
                            break;
                        case 6:

                            x.Text = "x6";
                            S.Text = "S2";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 2;
                            break;
                        case 7:

                            x.Text = "x7";
                            S.Text = "S3";
                            y.Text = "y0";

                            hisCon.Children.Add(x);
                            hisCon.Children.Add(S);
                            hisCon.Children.Add(y);

                            numOfRow++;

                            condition = 3;
                            break;
                    }
                    break;
            }
        }

        private void x0(object sender, RoutedEventArgs e)
        {
            HandlerCondition(0);
        }
        private void x1(object sender, RoutedEventArgs e)
        {
            HandlerCondition(1);
        }
        private void x2(object sender, RoutedEventArgs e)
        {
            HandlerCondition(2);
        }
        private void x3(object sender, RoutedEventArgs e)
        {
            HandlerCondition(3);
        }
        private void x4(object sender, RoutedEventArgs e)
        {
            HandlerCondition(4);
        }
        private void x5(object sender, RoutedEventArgs e)
        {
            HandlerCondition(5);
        }
        private void x6(object sender, RoutedEventArgs e)
        {
            HandlerCondition(6);
        }
        private void x7(object sender, RoutedEventArgs e)
        {
            HandlerCondition(7);
        }

        private void GoToPetriNet(object sender, RoutedEventArgs e)
        {
            PetriNet petriNet = new PetriNet();
            petriNet.Show();

            this.Close();

        }
    }
}
