using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_Exam02
{
    internal class FinalExam : Exam
    {
        // Can accept from both TOF & MCQ
        public Question[] Questions { get; set; }

        public FinalExam(int timeOfExam, int numberOfQuestions, Question[] questions)
            : base(timeOfExam, numberOfQuestions)
        {
            Questions = questions;
        } 

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam\n==========\n");
            Console.WriteLine($"{NumberOfQuestions} Questions. Time allowed {TimeOfExam} minutes");
            Console.WriteLine();
            int Grade = 0;
            foreach (Question question in Questions)
            {
                question.DisplayQuestion();
                if (question is TrueOrFalse)
                {
                    TrueOrFalse temp = (TrueOrFalse)question;
                    bool userChoice = Convert.ToBoolean(Console.ReadLine());
                    if (userChoice == temp.IsCorrect)
                    {
                        Grade += temp.Mark;
                    }

                }
                else
                {
                    MCQ mcq = (MCQ)question;
                    int userAnswer = Convert.ToInt32(Console.ReadLine());
                    if (userAnswer == mcq.CorrectIndex + 1)
                    {
                        Grade += mcq.Mark;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Good Luck");
            Console.WriteLine();
            Console.WriteLine("Answers\n=======\n");
            foreach (Question question in Questions)
            {
                Console.WriteLine($"{question}\n");                
            }
            Console.WriteLine($"Your score is {Grade}");
        }
    }
}
