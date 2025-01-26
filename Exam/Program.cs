namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter subject name:");
            string subjectName = Console.ReadLine();

            Console.WriteLine("Enter subject ID:");
            int subjectId = int.Parse(Console.ReadLine());

            Subject subject = new Subject(subjectId, subjectName);

            Console.WriteLine("Enter type of exam (Final | Practical):");
            string examType = Console.ReadLine();

            Console.WriteLine("Enter time of exam (in minutes):");
            int examTime = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter total mark of the exam:");
            int totalMark = int.Parse(Console.ReadLine());

            Exam exam;
            if (examType.Equals("Final") || examType.Equals("final"))
            {
                exam = new FinalExam(examTime, totalMark);

                Console.WriteLine("Enter number of questions:");
                int numberOfQuestions = int.Parse(Console.ReadLine());

                for (int i = 0; i < numberOfQuestions; i++)
                {
                    Console.WriteLine($"Enter details for question {i + 1}:");

                    Console.WriteLine("Enter question type (TrueFalse | MCQ):");
                    string questionType = Console.ReadLine();

                    Console.WriteLine("Enter question header:");
                    string header = Console.ReadLine();

                    Console.WriteLine("Enter question body:");
                    string body = Console.ReadLine();

                    Console.WriteLine("Enter question mark:");
                    int mark = int.Parse(Console.ReadLine());

                    if (questionType.Equals("TrueFalse"))
                    {
                        Question question = new TrueFalseQuestion(header, body, mark);

                        Console.WriteLine("Enter correct answer (True | False):");
                        string correctAnswerText = Console.ReadLine();
                        question.CorrectAnswer = new Answer(correctAnswerText.Equals("True") ? 1 : 2, correctAnswerText);

                        exam.Questions.Add(question);
                    }
                    else if (questionType.Equals("MCQ"))
                    {
                        Console.WriteLine("Enter number of choices:");
                        int numberOfChoices = int.Parse(Console.ReadLine());

                        var choices = new List<Answer>();
                        for (int j = 0; j < numberOfChoices; j++)
                        {
                            Console.WriteLine($"Enter choice {j + 1} text:");
                            string choiceText = Console.ReadLine();
                            choices.Add(new Answer(j + 1, choiceText));
                        }

                        Question question = new MCQQuestion(header, body, mark, choices);

                        Console.WriteLine("Enter the number of the correct choice:");
                        int correctChoiceId = int.Parse(Console.ReadLine());

                        exam.Questions.Add(question);
                    }
                }
            }
            else if (examType.Equals("Practical") || examType.Equals("practical"))
            {
                exam = new PracticalExam(examTime, totalMark);

                Console.WriteLine("Enter number of MCQ questions:");
                int numberOfQuestions = int.Parse(Console.ReadLine());

                for (int i = 0; i < numberOfQuestions; i++)
                {
                    Console.WriteLine($"Enter details for MCQ question {i + 1}:");

                    Console.WriteLine("Enter question header:");
                    string header = Console.ReadLine();

                    Console.WriteLine("Enter question body:");
                    string body = Console.ReadLine();

                    Console.WriteLine("Enter question mark:");
                    int mark = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter number of choices:");
                    int numberOfChoices = int.Parse(Console.ReadLine());

                    var choices = new List<Answer>();
                    for (int j = 0; j < numberOfChoices; j++)
                    {
                        Console.WriteLine($"Enter choice {j + 1} text:");
                        string choiceText = Console.ReadLine();
                        choices.Add(new Answer(j + 1, choiceText));
                    }

                    Question question = new MCQQuestion(header, body, mark, choices);

                    Console.WriteLine("Enter the number of the correct choice:");
                    int correctChoiceId = int.Parse(Console.ReadLine());

                    exam.Questions.Add(question);
                }
            }
            else
            {
                Console.WriteLine("Please enter one of this exam types");
                return;
            }

            Console.WriteLine("Do you want to start the exam ? (Y | N)");
            char starting=char.Parse(Console.ReadLine());

            if (starting == 'Y' || starting == 'y')
            {
                subject.CreateExam(exam);

                Console.WriteLine(subject);
                subject.SubjectExam.ShowExam();
            }
            else if (starting == 'N' || starting == 'n')
                Console.WriteLine("Ok,see you soon");
            
        }
    }
    
    
}
