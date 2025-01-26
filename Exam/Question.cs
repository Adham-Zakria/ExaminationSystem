using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal abstract class Question
    {
        public string HeaderOfTheQuestion { get; set; }
        public string BodyOfTheQuestion { get; set; }

        public int Mark { get; set; }

        public List<Answer> AnswerList { get; set; }

        public Answer CorrectAnswer;

        protected Question(string header, string body, int mark)
        {
            HeaderOfTheQuestion = header;
            BodyOfTheQuestion = body;
            Mark = mark;
            AnswerList = new List<Answer>();
        }

        public override string ToString() { 
           return $"HeaderOfTheQuestion : {HeaderOfTheQuestion} " +
                $", BodyOfTheQuestion : {BodyOfTheQuestion} , Mark : {Mark} ";
        }

        public abstract void Display();


    }
}
