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
    /// Логика взаимодействия для DescriptionAndInstruction.xaml
    /// </summary>
    public partial class DescriptionAndInstruction : Window
    {
        private string TextOfDescription = "Автор В. Э. Мильман. Методика позволяет выявлять " +
            "некоторые устойчивые тенденции личности: общую и творческую активность, " +
            "стремление к общению, обеспечению комфорта и социального статуса и др. На " +
            "основе всех ответов можно составить суждение о рабочей (деловой) и общежитейской " +
            "направленности личности.",
         TextOfInstruction = "Вам будет представлено 14 утверждений, касающихся жизненных устремлений " +
            "и некоторых сторон образа жизни человека. Просим вас высказать отношение к ним по каждому из " +
            "8 вариантов ответов, проставив одну из следующих оценок каждого утверждения: «согласен с этим», " +
            "«когда как», «нет, не согласен», «не знаю». Старайтесь отвечать быстро, не задумывайтесь долго " +
            "над ответами.На всю работу у вас должно уйти не более 20 минут.";

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainW = new MainWindow();
            this.Close();
            MainW.Show();
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonDownload_Click(object sender, RoutedEventArgs e)
        {

        }

        public DescriptionAndInstruction()
        {
            InitializeComponent();
            _lableNameOfTest.Content = "Дианостика мотивационной структуры личности";
            DescriptionOfTest.Text = TextOfDescription;
            InstructionOfTest.Text = TextOfInstruction;
        }
    }
}
