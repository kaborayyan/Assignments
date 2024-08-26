using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_EF01.Entity
{
    internal class Instructor
    {
        public int InstructorID { get; set; }
        public string InstructorName { get; set; }
        public double Bonus { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
        public double HourRate { get; set; }

        // Navigational Property for many to many with fields
        public ICollection<CourseInstructor> InstructorCourses { get; set; } = new HashSet<CourseInstructor>();

        [ForeignKey("Department")]
        public int? DepartmentID { get; set; }

        // Navigational Property => One
        public Department Department { get; set; }
    }
}
