using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace psychologicaltestlib
{
    public class ConvertTestToXL : IDataSaveInterface
    {
        #region Fields
        private double ConstK = 5.688448074679113;
        private IVariousTestTemplate _variousTest;
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

        }
        #endregion Constructors
    }
}
