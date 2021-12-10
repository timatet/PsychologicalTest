using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using psychologicaltestlib;

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для DescriptionAndInstruction.xaml
    /// </summary>
    public partial class DescriptionAndInstruction : Window
    {
        PsychologicalTest psychologicalTest;
        public DescriptionAndInstruction(PsychologicalTest psychologicalTest)
        {
            InitializeComponent();
            this.psychologicalTest = psychologicalTest;
        }
        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            if (Button_continue_start.Text == "Дальше")
            {
                MainWindow MainW = new MainWindow();
                this.Close();
                MainW.Show();
            }
            else
            {
                // скрыть инструкцию, окрыть описание, поменять название кнопки
                BorderDescriptionOfTest.Visibility = Visibility.Visible;
                BorderInstructionOfTest.Visibility = Visibility.Hidden;
                Button_continue_start.Text = "Дальше";
            }
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            if (Button_continue_start.Text == "Начать")
            {
                //открыть окно теста
                string NameOfTest = _lableNameOfTest.Content.ToString();

                switch (NameOfTest)
                {
                    case "Диагностика мотивационной структуры личности":
                        MotivationTest MotTest = new MotivationTest(psychologicalTest);
                        this.Close();
                        MotTest.Show();
                        break;
                    case "Личностные творческие характеристики":
                        CreativeCharacteristicsTest CrChTest = new CreativeCharacteristicsTest(psychologicalTest);
                        this.Close();
                        CrChTest.Show();
                        break;
                }
            }
            else
            {
                // скрыть описание, окрыть инструкцию, поменять название кнопки
                BorderDescriptionOfTest.Visibility = Visibility.Hidden;
                BorderInstructionOfTest.Visibility = Visibility.Visible;
                Button_continue_start.Text = "Начать";
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
                    pathOfTest = "motivatsia.pdf";
                    break;
                case "Личностные творческие характеристики":
                    pathOfTest = "tworchestvo.pdf";
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
    }
}
