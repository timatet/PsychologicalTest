//using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace psychologicaltestlib
{
    public class ConvertTestToXL : IDataSaveInterface
    {
        #region Fields
        private IVariousTestTemplate _variousTest;
        #endregion Fields

        #region Method
        public void Print(UserClass _User)
        {
            //var ans = _User;
            //var file_name = _variousTest.GetNameOfTest();
            //FileInfo fi = new FileInfo(@"Path\To\Your\File.xlsx");
            //using (ExcelPackage excelPackage = new ExcelPackage(fi))
            //{
            //    // Получение листа (Worksheet), созданного в предыдущем примере:
            //    var ws = excelPackage.Workbook.Worksheets[1];
            //    int start_index = 1;
            //    while(true)
            //    {
            //        if ((string)ws.Cells[start_index, 1].Value == "")
            //        {
            //            break;
            //        }
            //        start_index ++;
            //    }
            //    ws.Cells[start_index, 1].Value = DateTime.Now;
            //    int cur_row = 2;

            //    foreach(var item in ans)
            //    {
            //        ws.Cells[start_index, cur_row].Value = item.Value;
            //        cur_row ++;
            //    }               
            //}
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
