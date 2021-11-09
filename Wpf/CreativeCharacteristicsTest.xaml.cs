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
    /// Логика взаимодействия для CreativeCharacteristicsTest.xaml
    /// </summary>
    public partial class CreativeCharacteristicsTest : Window
    {
        public CreativeCharacteristicsTest()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
           //если это первый вопрос, то переводить на описание (а может на главную)
           // возращает к предыдущему вопросу (изменить вопрос, номер вопроса, прогресс, счетчик) и стирает ответ на вопрос
           
        }

        private void ButtonBreakOff_Click(object sender, RoutedEventArgs e)
        {
            // вывести окошко с предупреждением
            // в нем при выборе "да" - выкенет на инструкцию
            // "отмена" - уберет предупреждение
            AbortTheTest att = new AbortTheTest();
            att.Owner = this;
            att.Show();
        }

        private void RadioButton_Agree(object sender, RoutedEventArgs e)
        {
            //сохранить ответ 
            //вывести следующий вопрос
            //поменять номер
            //увеличить счетчик вопросов
            //изменить значение progressbar
            //если вопрос последний, то открыть уведомление

            /*открытие уведомления
            TestingIsOver tio = new TestingIsOver();
            tio.Show();*/
        }

        private void RadioButton_AgreeFomThePart(object sender, RoutedEventArgs e)
        {
            //сохранить ответ 
            //вывести следующий вопрос
            //поменять номер
            //увеличить счетчик вопросов
            //изменить значение progressbar
            //если вопрос последний, то открыть уведомление

            /*открытие уведомления
            TestingIsOver tio = new TestingIsOver();
            tio.Show();*/
        }

        private void RadioButton_Doubt(object sender, RoutedEventArgs e)
        {
            //сохранить ответ 
            //вывести следующий вопрос
            //поменять номер
            //увеличить счетчик вопросов
            //изменить значение progressbar
            //если вопрос последний, то открыть уведомление

            /*открытие уведомления
            TestingIsOver tio = new TestingIsOver();
            tio.Show();*/
        }

        private void RadioButton_Disagree(object sender, RoutedEventArgs e)
        {
            //сохранить ответ 
            //вывести следующий вопрос
            //поменять номер
            //увеличить счетчик вопросов
            //изменить значение progressbar
            //если вопрос последний, то открыть уведомление

            /*открытие уведомления
            TestingIsOver tio = new TestingIsOver();
            tio.Show();*/
        }
    }
}
