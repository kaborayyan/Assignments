using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_Exam02
{
    internal abstract class Exam
    {
        public int TimeOfExam { get; set; } 
        // Duration or Date ?
        // if date it will be
        // public DateTime TimeOfExam { get; set }
        public int NumberOfQuestions { get; set; }

        protected Exam(int timeOfExam, int numberOfQuestions)
        {
            TimeOfExam = timeOfExam;
            NumberOfQuestions = numberOfQuestions;            
        }

        public abstract void ShowExam();
    }
}
