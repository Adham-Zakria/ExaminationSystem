using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal abstract class Exam
    {
        protected Exam(int timeOfExam, int numberOfQuestions)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;
            Questions = new List<Question>(); 
        }

        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }

        public List<Question> Questions { get; set; }

        public abstract void ShowExam();

    }
}
