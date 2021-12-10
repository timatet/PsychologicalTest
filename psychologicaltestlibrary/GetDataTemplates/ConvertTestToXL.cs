using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace psychologicaltestlib
{
    public class ConvertTestToXL : IDataSaveInterface
    {
        #region Fields
        #endregion Fields

        #region Method
        public void Print(UserClass _User, string _NameTest)
        {
            var Scales = _User.GetScales();
            double AverageResultMax = 0;
            int CntScale = 1;
            foreach (var Scale in Scales)
            {
                AverageResultMax += _User.GetMaxForScale(Scale);
                CntScale++;
            }
            AverageResultMax /= CntScale;

            // _User.ResultDict - сырые данные
            // _User.AverageResultDict - взвешенные данные
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string path = Directory.GetCurrentDirectory() + @"\\" + _NameTest + ".xlsx";
            FileInfo fi = new FileInfo(path);
            using (ExcelPackage excelPackage = new ExcelPackage(fi))
            {
                // Получение листа (Worksheet), созданного в предыдущем примере:
                ExcelWorksheet ws;
                int cur_row;
                if (excelPackage.Workbook.Worksheets.Count != 0)
                    ws = excelPackage.Workbook.Worksheets[0];
                else
                {
                    ws = excelPackage.Workbook.Worksheets.Add("List1");
                    ws.Cells[1, 1].Value = "Взвешенные данные";
                    ws.Cells[1, 2].Value = "Сырые данные";
                    ws.Cells[2, 1].Value = "Date";
                    ws.Cells[2, 2].Value = "First Name";
                    ws.Cells[2, 3].Value = "Last Name";
                    ws.Cells[2, 4].Value = "Middle Name";
                    ws.Cells[2, 5].Value = "Age";
                    ws.Cells[2, 6].Value = "Sex";
                    ws.Cells[2, 7].Value = "Additional information";

                    cur_row = 8;
                    foreach (var item in _User.AverageResultDict)
                    {
                        ws.Cells[2, cur_row].Value = item.Key + " max" + _User.GetMaxForScale(item.Key);
                        cur_row++;
                    }

                    //// Выделяем диапазон ячеек от A1 до N1         
                    //excelPackage.Range _excelCells2 = (excelPackage.Range)ws.get_Range("A1", "N1").Cells;
                    //// Производим объединение
                    //_excelCells2.Merge(Type.Missing);
                    //ws.Cells[1, cur_row] = "Взвешенные данные";

                    foreach (var item in _User.ResultDict)
                    {
                        ws.Cells[2, cur_row].Value = item.Key + " max" + _User.GetMaxForScale(item.Key);
                        cur_row++;
                    }

                    //// Выделяем диапазон ячеек от N1 до Y1         
                    //excelPackage.Range _excelCells2 = (excelPackage.Range)ws.get_Range("N1", "Y1").Cells;
                    //// Производим объединение
                    //_excelCells2.Merge(Type.Missing);
                    //ws.Cells[1, cur_row] = "Сырые данные";

                    ws.Rows[1].Height = 20;
                    for (int i = 1; i < cur_row; i++)
                    {
                        ws.Cells[2, i].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        ws.Cells[2, i].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        ws.Cells[2, i].Style.Font.Bold = true;
                        ws.Cells[2, i].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        ws.Cells[2, i].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(255, 232, 197));
                    }

                    //ws.Cells[1, 8].Value = "Склонность к риску";
                    //ws.Cells[1, 9].Value = "Любознательность";
                    //ws.Cells[1, 10].Value = "Сложность";
                    //ws.Cells[1, 11].Value = "Воображение";
                }

                int start_index = 1;
                while (true)
                {
                    if (ws.Cells[start_index, 1].Value == null)
                    {
                        break;
                    }
                    start_index++;
                }

                ws.Columns[1].Width = 15;
                ws.Columns[2].Width = 15;
                ws.Columns[3].Width = 15;
                ws.Columns[4].Width = 15;
                ws.Columns[5].Width = 8;
                ws.Columns[6].Width = 8;
                ws.Columns[7].Width = 30;

                ws.Cells[start_index, 1].Style.Numberformat.Format = "yyyy-mm-dd";
                ws.Cells[start_index, 1].Value = DateTime.Now;
                ws.Cells[start_index, 2].Value = _User.FirstName;
                ws.Cells[start_index, 3].Value = _User.MiddleName;
                ws.Cells[start_index, 4].Value = _User.LastName;
                ws.Cells[start_index, 5].Style.Numberformat.Format = "0";
                ws.Cells[start_index, 5].Value = _User.Age;
                ws.Cells[start_index, 6].Value = _User.Gender;
                ws.Cells[start_index, 7].Value = _User.DopInfo;

                cur_row = 8;

                foreach (var item in _User.AverageResultDict)
                {
                    ws.Cells[start_index, cur_row].Style.Numberformat.Format = "0.0";
                    ws.Cells[start_index, cur_row].Value = item.Value;

                    ws.Columns[cur_row].Width = 30;
                    cur_row++;
                }
                foreach (var item in _User.ResultDict)
                {
                    ws.Cells[start_index, cur_row].Style.Numberformat.Format = "0.0";
                    ws.Cells[start_index, cur_row].Value = item.Value;

                    ws.Columns[cur_row].Width = 30;
                    cur_row++;
                }
                excelPackage.Save();

            }
            //Здесь реализация метода печати в XL файл
        }
        #endregion Methods

        #region Constructors
        public ConvertTestToXL()
        {
            
        }
        #endregion Constructors
    }
}
