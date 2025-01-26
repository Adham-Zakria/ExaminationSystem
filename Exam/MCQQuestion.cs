using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class MCQQuestion : Question
    {
   
        public MCQQuestion(string header, string body, int mark, List<Answer> answers) : base(header, body, mark)
        {
            AnswerList = answers;
        }

        public override void Display()
        {
            Console.WriteLine($"{HeaderOfTheQuestion}: {BodyOfTheQuestion} (Mark: {Mark})");
            foreach (Answer answer in AnswerList)
            {
                Console.WriteLine($"{answer.AnswerId}. {answer.AnswerText}");
            }
        }
    }
}
