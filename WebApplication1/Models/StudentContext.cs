using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.StudentConfig;

namespace WebApplication1.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }

        //Applying StudentConfigurations to Model Tables
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Student>(new StudentConfiguration());
            modelBuilder.ApplyConfiguration<Batch>(new StudentConfiguration());
        }

        public DbSet<Student> Student { set; get; }
        public DbSet<Batch> Batch { set; get; }
        //public DbSet<StudentViewModel> StudentViewModel { set; get; }
        //public DbSet<BatchViewModel> BatchViewModel { set; get; }
    }
}
