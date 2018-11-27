using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Batch
    {
        public Batch()
        {
            batchId = new Guid();
        }

        //Primary Key
        [Key]
        public Guid batchId { get; set; }

        [Required(ErrorMessage ="Enter name")]
        //regular expression for match only alphabets
        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Enter only words please")]
        public String batchName { get; set; }
    }
}
