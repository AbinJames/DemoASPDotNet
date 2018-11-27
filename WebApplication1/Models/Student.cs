using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Student
    {
        public Student()
        {
            studentId = new Guid();
        }

        //Primary key
        [Key]
        public Guid studentId { get; set; }

        [Required(ErrorMessage = "Enter name")]
        //regular expression for match only alphabets
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Enter only words please")]
        public String studentName { get; set; }

        //Foreign key with batchid in Batch Table
        //batchId is set as nullable inorder to enter null values in column
        [ForeignKey("Batch")]
        public Guid? batchId { get; set; }
       
    }
}
