using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_Exam02
{
    internal class TrueOrFalse: Question
    {
        public bool IsCorrect { get; set; }

        public TrueOrFalse(string header, string body, int mark, bool isCorrect): base( header, body, mark)
        {
            IsCorrect = isCorrect;
        }

        public override void DisplayQuestion()
        {
            Console.Write($"{Header} ({Mark} marks)\n{Body}\nYour answer is: ");
        }
        public override string ToString()
        {
            return $"{Header}\n{Body}\nThis question is: {IsCorrect}";
        }
    }
}
