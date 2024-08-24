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
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> student)
        {
            student.HasKey(S => S.StudentID);
            student.Property(S => S.StudentID).UseIdentityColumn(1, 1);
            student.Property(S => S.FirstName).HasColumnType("varchar").HasMaxLength(50);
            student.Property(S => S.LastName).HasColumnType("varchar").HasMaxLength(50);
            student.Property(S => S.Address).HasMaxLength(50).HasDefaultValue("Cairo");
        }
    }
}
