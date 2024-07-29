using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_Exam02
{
    internal class PracticalExam : Exam
    {
        public MCQ[] Questions { get; set; }
        public PracticalExam(int timeOfExam, int numberOfQuestions, MCQ[] questions)
            : base(timeOfExam, numberOfQuestions)
        {
            Questions = questions;
        }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam\n==============\n");
            Console.WriteLine($"{NumberOfQuestions} Questions. Time allowed {TimeOfExam} minutes");
            Console.WriteLine();
            int Grade = 0;
            foreach (MCQ mcq in Questions)
            {
                mcq.DisplayQuestion();
                int userAnswer = Convert.ToInt32(Console.ReadLine());
                if (userAnswer == mcq.CorrectIndex + 1)
                {
                    Grade += mcq.Mark;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Good Luck");
            Console.WriteLine();
            Console.WriteLine("Answers\n=======\n");
            foreach (Question question in Questions)
            {
                Console.WriteLine($"{question}\n"); ;
            }
            Console.WriteLine($"Your score is {Grade}");
        }
    }
}
