using System;
using psychologicaltestlib;

namespace libtestapp
{
    class Program
    {
        static void Main(string[] args)
        {
            PsychologicalTest motivationTest = new PsychologicalTest(new MotivationTestType());
            //PsychologicalTest motivationTest = new PsychologicalTest(new TworchestvoTestType());

            //motivationTest.InitQuestions();

            Random rnd = new Random(DateTime.Now.Millisecond);
            foreach (Question q in motivationTest)
            {
                q.SetAnswer(rnd.Next(0, 3));
            }

            //for (int i = 0; i < 14; i++)
            //{
            //    for (char j = 'A'; j <= 'H'; j++)
            //        Console.WriteLine($"{i + 1}{j}: " + motivationTest[$"{i + 1}{j}"].QuestionName + "\n" + motivationTest[$"{i + 1}{j}"].QuestionAnswer);
            //}

            UserClass uc = new UserClass("Ivan", "Ivanov", "Ivanovich", "school", 15, "dopinfo");
            //motivationTest.RegisterUser(uc);
            //motivationTest.SaveResults(new ConvertTestToPDF());
        }
    }
}
