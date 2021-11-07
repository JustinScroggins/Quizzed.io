using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quizzed.Entities.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public string Body { get; set;
        }
        [ForeignKey(nameof(WrongAnswer))]
        public int WrongAnswerId { get; set; }
        public IEnumerable<WrongAnswer> WrongAnswers { get; set; }
    }
}
