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
                    new Quiz
                    {
                        Id = 1,
                        Name = "Primitive Types and Expressions",
                        CreatedOn = new DateTime(2021, 11, 7),
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
                                        QuestionAnswerId = 1,
                                        Body = "int number = 2;"
                                    },
                                    new Answer
                                    {

                                    }
                                }
                            }
                        }
                    }
                );
        }
    }
}
