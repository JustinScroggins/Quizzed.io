using Quizzed.Contracts;
using Quizzed.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzed.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private IAnswerRepository _answerRepository;
        private IConceptRepository _conceptRepository;
        private IQuestionRepository _questionRepository;
        private IQuizRepository _quizRepository;
        private ISubjectRepository _subjectRepository;

        public IAnswerRepository Answer
        {
            get
            {
                if (_answerRepository == null)
                    _answerRepository = new AnswerRepository(_repositoryContext);

                return _answerRepository;
            }
        }

        public IConceptRepository Concept
        {
            get
            {
                if (_conceptRepository == null)
                    _conceptRepository = new ConceptRepository(_repositoryContext);

                return _conceptRepository;
            }
        }
        public IQuestionRepository Question
        {
            get
            {
                if (_questionRepository == null)
                    _questionRepository = new QuestionRepository(_repositoryContext);

                return _questionRepository;
            }
        }

        public IQuizRepository Quiz
        {
            get
            {
                if (_quizRepository == null)
                    _quizRepository = new QuizRepository(_repositoryContext);

                return _quizRepository;
            }
        }

        public ISubjectRepository Subject
        {
            get
            {
                if (_subjectRepository == null)
                    _subjectRepository = new SubjectRepository(_repositoryContext);

                return _subjectRepository;
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
