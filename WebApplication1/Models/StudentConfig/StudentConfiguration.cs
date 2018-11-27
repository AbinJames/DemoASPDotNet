using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.StudentConfig
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>, IEntityTypeConfiguration<Batch>
    {
        //Configuration for student table 
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(prop => prop.studentId);
            builder.Property(prop => prop.studentName)
                .HasMaxLength(50)
                .IsRequired();
        }

        //Configuration for batch table
        public void Configure(EntityTypeBuilder<Batch> builder)
        {
            builder.HasKey(prop => prop.batchId);
            builder.Property(prop => prop.batchName)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
