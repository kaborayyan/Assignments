using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_EF01.Entity
{
    internal class Topic
    {
        public int TopicID { get; set; }
        public string TopicName { get; set; }

        [ForeignKey("Course")]
        public int? CourseID { get; set; }

        // Navigational Property => One
        public Course Course { get; set; }
    }
}
