using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class StudentViewModel
    {
        //View Model for storing the student name and batch name from join operation
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Enter name")]
        //regular expression for match only alphabets
        [RegularExpression(@"^[a-zA-Z ]$", ErrorMessage = "Enter only words please")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter batch")]
        //regular expression for match only alphabets
        [RegularExpression(@"^[a-zA-Z ]$", ErrorMessage = "Enter only words please")]
        public string BatchName { get; set; }
    }
}
