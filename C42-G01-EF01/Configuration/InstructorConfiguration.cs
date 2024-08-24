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
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> inst)
        {
            inst.HasKey(i => i.InstructorID);
            inst.Property(i => i.InstructorID).UseIdentityColumn(1, 1);
            inst.Property(i => i.InstructorName).HasColumnType("varchar").HasMaxLength(50);            
            inst.Property(i => i.Address).HasMaxLength(50).HasDefaultValue("Cairo");
        }
    }
}
