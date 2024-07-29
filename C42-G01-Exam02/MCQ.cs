using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_Exam02
{
    internal class MCQ: Question
    {
        public Answer[] Answers { get; set; }
        public int CorrectIndex { get; set; }
        public MCQ(string header, string body, int mark, Answer[] answers, int correctIndex):base( header, body, mark)
        {
            Answers = answers;
            CorrectIndex = correctIndex;
        }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Header} ({Mark} marks)\n{Body}\n");
            foreach( Answer answer in Answers )
                Console.WriteLine(answer);
            Console.Write($"Please enter your choice: ");
        }
        public override string ToString()
        {
            return $"{Header}\n{Body}\nThe correct answer is: {Answers[CorrectIndex]}";
        }
    }
}
