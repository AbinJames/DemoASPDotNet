using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class BatchViewModel
    {
        //View model for storing group join operation result
        [Key]
        public Guid Id;

        public IEnumerable<Student> student { get; set; }
        public string batch { get; set; }
    }
}
