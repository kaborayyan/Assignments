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
    internal class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> topic)
        {
            topic.HasKey(T => T.TopicID);
            topic.Property(T => T.TopicID).UseIdentityColumn(1, 1);
            topic.Property(T => T.TopicName).HasColumnType("varchar").HasMaxLength(50);
        }
    }
}
