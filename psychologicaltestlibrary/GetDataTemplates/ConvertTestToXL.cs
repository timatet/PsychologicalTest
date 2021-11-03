using System.Collections.Generic;
using System.Drawing;
using System.IO;
using IronXL;
using IronXL.Styles;

namespace psychologicaltestlib
{
    public class ConvertTestToXL : IDataSaveInterface
    {
        #region Fields
        private double ConstK = 5.688448074679113;
        private IVariousTestTemplate _variousTest;
        private WorkBook xlsWorkbook;
        #endregion Fields

        #region Methods
        public void Print(List<UserClass> _Users)
        {
            //Здесь реализация метода печати в XL файл
        }
        #endregion Methods

        #region Constructors
        public ConvertTestToXL()
        {
            xlsWorkbook = WorkBook.Create(ExcelFileFormat.XLS);
        }
        #endregion Constructors
    }
}
