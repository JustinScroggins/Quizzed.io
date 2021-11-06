using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Quizzed.Entities.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public string CorrectAnswers { get; set; }
        public ICollection<string> WrongAnswers { get; set; }
    }
}
