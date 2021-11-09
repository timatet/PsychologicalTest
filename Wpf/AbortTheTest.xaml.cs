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
    /// Логика взаимодействия для AbortTheTest.xaml
    /// </summary>
    public partial class AbortTheTest : Window
    {
        public AbortTheTest()
        {
            InitializeComponent();
        }

        private void MouseDown_Click(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void ButtonСancel_Click(object sender, RoutedEventArgs e)
        {
            //закрыть окно
            this.Close();
        }

        private void ButtonBreakYes_Click(object sender, RoutedEventArgs e)
        {
            // вернуться на главную
            MainWindow mw = new MainWindow();
            this.Close();
            this.Owner.Close();
            mw.Show();
        }
    }
}
