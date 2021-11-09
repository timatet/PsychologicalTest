using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainW = new MainWindow();
            this.Close();
            MainW.Show();
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            //открыть окно теста
            string NameOfTest = _lableNameOfTest.Content.ToString();

            switch (NameOfTest)
            {
                case "Диагностика мотивационной структуры личности":
                    MotivationTest MotTest = new MotivationTest();
                    this.Close();
                    MotTest.Show();
                    break;
                case "Личностные творческие характеристики":
                    CreativeCharacteristicsTest CrChTest = new CreativeCharacteristicsTest();
                    this.Close();
                    CrChTest.Show();
                    break;
            }
        }

        string FilePath { get; set; }
        string GetDownloadFolderPath()
        {
            return Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
        }

        private void ButtonDownload_Click(object sender, RoutedEventArgs e)
        {
            //скачать файл с тестом
            bool fileIsLoaded = false;
            MessageWindow mw = new MessageWindow();
            string message = "", pathOfTest = "";
            switch (_lableNameOfTest.Content.ToString())
            {
                case "Диагностика мотивационной структуры личности":
                    pathOfTest = "Мотивационная структура личности- Мильман полн..pdf";
                    break;
                case "Личностные творческие характеристики":
                    pathOfTest = "Личностные творческие характеристики Туник (полный вар).pdf";
                    break;
            }
            string DownloadPath = GetDownloadFolderPath() + "\\" + pathOfTest;
            try
            {
                File.Copy(pathOfTest, DownloadPath);
            }
            catch
            {
                fileIsLoaded = true;
                message = "Файл " + DownloadPath + " уже существует.";
                File.Open(DownloadPath, FileMode.Open);
                mw.MessageTextBlock.FontSize = 15;
            }
            if (!fileIsLoaded)
            {
                FileInfo fi = new FileInfo(DownloadPath);
                fi.LastWriteTime = DateTime.Now;
                message = "Файл сохранен в папку \"Загрузки\"";
            }
            mw.MessageTextBlock.Text = message;
            mw.ShowDialog();
        }

        public DescriptionAndInstruction()
        {
            InitializeComponent();
        }
    }
}
