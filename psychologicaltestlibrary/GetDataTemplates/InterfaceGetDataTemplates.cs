using System.Collections.Generic;

namespace psychologicaltestlib
{
    public interface IDataSaveInterface
    {
        void Print(string Name, string Desc, Dictionary<string, Question> Answ);
    }
}
