using OfficeOpenXml;
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
                    ws.Cells[1, 1].Value = "Date";
                    ws.Cells[1, 2].Value = "First Name";
                    ws.Cells[1, 3].Value = "Last Name";
                    ws.Cells[1, 4].Value = "Middle Name";
                    ws.Cells[1, 5].Value = "Age";
                    ws.Cells[1, 6].Value = "Sex";
                    ws.Cells[1, 7].Value = "Additional information";
                    cur_row = 8;
                    foreach (var item in _User.ResultDict)
                    {
                        ws.Cells[1, cur_row].Value = item.Key;
                        cur_row++;
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
                ws.Cells[start_index, 1].Value = DateTime.Now;
                ws.Cells[start_index, 2].Value = _User.FirstName;
                ws.Cells[start_index, 3].Value = _User.MiddleName;
                ws.Cells[start_index, 4].Value = _User.LastName;
                ws.Cells[start_index, 5].Value = _User.Age;
                ws.Cells[start_index, 6].Value = _User.Gender;
                ws.Cells[start_index, 7].Value = _User.DopInfo;

                cur_row = 8;

                foreach (var item in _User.ResultDict)
                {
                    ws.Cells[start_index, cur_row].Value = item.Value;
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
