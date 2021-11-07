using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzed.Contracts
{
    public interface IRepositoryManager
    {
        IAnswerRepository Answer { get; }
        IConceptRepository Concept { get; }
        IQuestionRepository Question { get; }
        IQuizRepository Quiz { get; }
        ISubjectRepository Subject { get; }
        void Save();
    }
}
