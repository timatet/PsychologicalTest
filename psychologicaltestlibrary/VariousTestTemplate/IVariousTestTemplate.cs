using System.Collections.Generic;

namespace psychologicaltestlib
{
    public interface IVariousTestTemplate
    {
        Dictionary<string, Question> Asks { get; set; }

        Dictionary<string, int> Processing();
        Dictionary<string, double> GetAverageResults(Dictionary<string, int> TestResults);
        void InitQuestions();
        string[] GetScales();

        string GetNameOfTest();
        string GetDescriptionOfTest();
        string GetInstructionOfTest();

        int GetMaxForScale(string scale);
    }
}
