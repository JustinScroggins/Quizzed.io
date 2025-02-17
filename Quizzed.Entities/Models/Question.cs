﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzed.Entities.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The question body is required.")]
        [Display(Name = "Question Body")]
        public string Body { get; set; }
        [ForeignKey(nameof(Quiz))]
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
        public ICollection<Answer> Answers { get; set; }
        public Concept Concept { get; set; }
    }
}
