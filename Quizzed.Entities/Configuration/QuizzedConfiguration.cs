using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quizzed.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzed.Entities.Configuration
{
    public class QuizzedConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.HasData
                (
                        new Subject
                        {
                            Id = 1,
                            Name = "C#",
                            Concepts = new List<Concept>
                            {
                                new Concept
                                {
                                    Id = 1,
                                    Name = "Variables",
                                    Explanation = "Variables are areas in memory which hold data of various types and are used for referencing in the code.",
                                    CreatedOn = DateTime.Now
                                }
                            }
                        },
                    new Quiz
                    {
                        Id = 1,
                        Name = "Primitive Types and Expressions",
                        CreatedOn = new DateTime(1980, 1, 2),
                        Questions = new List<Question>
                        {
                            new Question
                            {
                                Id = 1,
                                Body = "Which of the following is an example of a declared and initialized variable?",
                                Answers = new List<Answer>()
                                {
                                    new Answer
                                    {
                                        Id = 1,
                                        IsAnswer = true,
                                        AnswerGroupId = 1,
                                        Body = "int number = 2;"
                                    },
                                    new Answer
                                    {
                                        Id = 2,
                                        IsAnswer= false,
                                        AnswerGroupId = 1,
                                        Body= "int number;"
                                    },
                                    new Answer
                                    {
                                        Id = 3,
                                        IsAnswer = false,
                                        AnswerGroupId = 1,
                                        Body = "var number = 2"
                                    },
                                    new Answer
                                    {
                                        Id = 4,
                                        IsAnswer = false,
                                        AnswerGroupId = 1,
                                        Body = "number = 2;"
                                    }
                                }
                            }
                        }
                    });
        }
    }
}
