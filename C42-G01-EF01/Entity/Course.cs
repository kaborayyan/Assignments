using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_EF01.Entity
{
    internal class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }

        // Navigational Property
        // For many to many with fields on the relation
        public ICollection<StudentCourse> CourseStudents { get; set; } = new HashSet<StudentCourse>();

        // Navigational Property
        // One to many with Topic
        public ICollection<Topic> Topics { get; set; } = new HashSet<Topic>();

        // Navigational Property
        // For many to many with fields on the relation
        public ICollection<CourseInstructor> CourseInstructors { get; set; } = new HashSet<CourseInstructor>();
    }
}
