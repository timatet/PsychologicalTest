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

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для MotivationTest.xaml
    /// </summary>
    public partial class MotivationTest : Window
    {
        public MotivationTest()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonBreakOff_Click(object sender, RoutedEventArgs e)
        {
            AbortTheTest att = new AbortTheTest();
            att.Owner = this;
            att.Show();            
        }

        private void RadioButton_Agree(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_FiftyFifty(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Disagree(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_DontKnow(object sender, RoutedEventArgs e)
        {

        }
    }
}
