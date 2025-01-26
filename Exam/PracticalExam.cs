using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int timeOfExam, int numberOfQuestions) : base(timeOfExam, numberOfQuestions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam:");
            foreach (Question question in Questions)
            {
                question.Display();
                Console.WriteLine($"Correct Answer: {question.CorrectAnswer.AnswerText}");
            }
        }

    }
}
