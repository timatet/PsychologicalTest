using System.Collections.Generic;

namespace psychologicaltestlib
{
    public interface IVariousTestTemplate
    {
        Dictionary<string, Question> Asks { get; set; }

        Dictionary<Scale, int> Processing();
        void InitQuestions();
    }
}
