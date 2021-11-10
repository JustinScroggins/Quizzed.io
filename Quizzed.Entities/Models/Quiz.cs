using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzed.Entities.Models
{
    public class Quiz
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The quiz name is a required field")]
        [MaxLength(99, ErrorMessage = "The quiz name must be less than 99 characters")]
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public IEnumerable<Question> Questions { get; set; }
        public Subject Subject { get; set; }
    }
}
