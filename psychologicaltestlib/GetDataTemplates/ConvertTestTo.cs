using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace psychologicaltestlib
{
    public class ConvertTestTo : IDataSaveInterface
    {
        #region Fields
        private Dictionary<string, int> _Results;
        #endregion Fields

        #region Methods
        public void Print()
        {
            
        }
        #endregion Methods

        public ConvertTestTo(Dictionary<string, int> results)
        {
            _Results = results;
        }
    }
}
