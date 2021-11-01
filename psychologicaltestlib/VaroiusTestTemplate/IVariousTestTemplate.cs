using System;
using System.Collections.Generic;

namespace psychologicaltestlib
{
    public interface IVariousTestTemplate
    {
        Dictionary<string, Question> Asks { get; set; }

        Dictionary<string, int> Processing();
        void InitQuestions();
        string[] GetScales();
    }
}
