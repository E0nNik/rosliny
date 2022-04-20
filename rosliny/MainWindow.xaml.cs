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

namespace rosliny
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void check1(object sender, RoutedEventArgs e)
        {
            if (box1.IsChecked == true)
            {
                nr1.Visibility = Visibility.Visible;
            }
            else
            {

                nr1.Visibility = Visibility.Hidden;
            }
            
        }

        private void check4(object sender, RoutedEventArgs e)
        {
            if (box4.IsChecked == true)
            {
                nr4.Visibility = Visibility.Visible;
            }
            else
            {

                nr4.Visibility = Visibility.Hidden;
            }
        }

        private void check2(object sender, RoutedEventArgs e)
        {
            if (box2.IsChecked == true)
            {
                nr2.Visibility = Visibility.Visible;
            }
            else
            {

                nr2.Visibility = Visibility.Hidden;
            }
        }

        private void check3(object sender, RoutedEventArgs e)
        {
            if (box3.IsChecked == true)
            {
                nr3.Visibility = Visibility.Visible;
            }
            else
            {

                nr3.Visibility = Visibility.Hidden;
            }
        }

        private void check5(object sender, RoutedEventArgs e)
        {
            if (box5.IsChecked == true)
            {
                nr5.Visibility = Visibility.Visible;
            }
            else
            {

                nr5.Visibility = Visibility.Hidden;
            }
        }

        private void check6(object sender, RoutedEventArgs e)
        {
            if (box6.IsChecked == true)
            {
                nr6.Visibility = Visibility.Visible;
            }
            else
            {

                nr6.Visibility = Visibility.Hidden;
            }
        }
    }
}
