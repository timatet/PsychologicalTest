﻿using IronPdf;
using System.Collections.Generic;

namespace psychologicaltestlib
{
    public class ConvertTestToPDF : IDataSaveInterface
    {
        #region Fields
        private IVariousTestTemplate _variousTest;
        private Dictionary<string, int> _Results;
        private ChromePdfRenderer pdf;
        #endregion Fields

        #region Methods
        public void Print(string Name, string Desc, Dictionary<string, Question> Answ)
        {
            //Здесь реализация метода печати в PDF файл
        }
        #endregion Methods

        #region Constructors
        public ConvertTestToPDF()
        {

        }
        #endregion Constructors
    }
}