using Microsoft.EntityFrameworkCore;
using Quizzed.Entities.Configuration;
using Quizzed.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzed.Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new QuizzedConfiguration());
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Concept> Concepts { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
