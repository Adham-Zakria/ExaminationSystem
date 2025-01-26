using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class FinalExam : Exam
    {
        public FinalExam(int timeOfExam, int numberOfQuestions) : base(timeOfExam, numberOfQuestions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam:");
            foreach (Question question in Questions)
            {
                question.Display();
            }
        }

    }
}
