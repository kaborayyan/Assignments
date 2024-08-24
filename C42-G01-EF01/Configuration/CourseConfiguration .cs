using C42_G01_EF01.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_EF01.Configuration
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> course)
        {
            course.HasKey(C => C.CourseID);
            course.Property(C => C.CourseID).UseIdentityColumn(10, 10);
            course.Property(C => C.CourseName).HasColumnType("varchar").HasMaxLength(50);            
            course.Property(C => C.Description).HasColumnType("varchar").HasMaxLength(100);
        }
    }
}
