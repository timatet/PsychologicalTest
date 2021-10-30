using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace psychologicaltestlib
{
    public class ConvertTestTo : IDataSaveInterface
    {
        #region Fields
        private Dictionary<Scale, int> _Results;
        #endregion Fields

        #region Methods
        public void Print()
        {
            
        }
        #endregion Methods

        public ConvertTestTo(Dictionary<Scale, int> results)
        {
            _Results = results;
        }
    }
}
