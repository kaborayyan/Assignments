using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_EF01.Entity
{
    internal class Department
    {
        public int DepartmentID { get; set; }
        public string DeptartmentName { get; set; }
        public DateTime HiringDate { get; set; }

        // Navigational Property => Many
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();

        // Navigational Property => Many
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
    }
}
