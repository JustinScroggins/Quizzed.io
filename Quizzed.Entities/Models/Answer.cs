﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quizzed.Entities.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public int AnswerGroupId { get; set; }
        public string Body { get; set; }
        public bool IsAnswer { get; set; }
        [ForeignKey(nameof(Question))]
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
