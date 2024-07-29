using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_Exam02
{
    internal class Subject
    {

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject(int subjectId, string subjectName, Exam exam)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
            Exam = exam;
        }
        
    }
}
